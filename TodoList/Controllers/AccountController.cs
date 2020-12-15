﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoList.Common.Utilities;
using TodoList.Models;
using TodoList.Services.IService;
using TodoList.ViewModels;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace TodoList.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IStaffService _staffService;

        public AccountController(IAccountService accountService, IStaffService staffService)
        {
            _accountService = accountService;
            _staffService = staffService;
        }

        [Authorize(Roles = "Leader")]
        public IActionResult Index()
        {
            var accounts = _staffService.GetAllUsers();

            /*
             * Constructs ViewModel
             */
            var viewModel = new AccountIndexVm
            {
                Accounts = accounts
            };

            return View(viewModel);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Username,Password")] AccountLoginVm viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var (username, password) = viewModel;
            SignInResult result = await _accountService.Login(username, password);

            if (result == SignInResult.Success)
            {
                return RedirectToAction("Index", "Home");
            }
            else if (result == SignInResult.Failed)
            {
                ModelState.AddModelError("", "Tên tài khoản hoặc mật khẩu không đúng!");
                return View(viewModel);
            }

            return View();
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _accountService.Logout();
            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Leader")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(
            [Bind("Username,Password,Password2,Staff")]
            AccountRegisterVm viewModel
        )
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var (username, password, staff) = viewModel;

            _staffService.AddStaff(staff); // Must be saved to have generated ID
            var result = await _accountService.CreateAndAddUser(username, password, staff);

            if (result != IdentityResult.Success)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                _staffService.RemoveStaff(staff); // Deleting newly added Staff if Registering failed

                return View(viewModel);
            }

            return RedirectToAction("Index", "Account");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _staffService.GetUser((int) id); // StaffId
            var roleName = (await _accountService.GetUserRoles(user.UserName)).FirstOrDefault();
            var roleId = roleName != null
                ? (int) EnumExtensions.ToDictionary<Level>()
                    .First(o => o.Value.Equals(roleName))
                    .Key
                : 0;

            /*
             * Constructs ViewModel
             */
            var viewModel = new AccountEditVm
            {
                ApplicationUser = user,
                StaffId = user.StaffId,
                RoleId = roleId
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("StaffId,RoleId")] AccountEditVm viewModel)
        {
            ModelState.Remove("ApplicationUser");
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var roleId = viewModel.RoleId;
            var user = _staffService.GetUser(viewModel.StaffId);
            
            var levelKeyPair = EnumExtensions.ToDictionary<Level>()
                .First(o => ((int) o.Key) == roleId);
            user.Staff.Level = levelKeyPair.Key;
            var roleName = levelKeyPair.Value;
            
            await _accountService.UpdateUserRole(user, roleName);
            _staffService.UpdateStaff(user.Staff);

            return RedirectToAction("Index");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}