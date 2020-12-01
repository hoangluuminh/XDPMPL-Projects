using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoList.Data;
using TodoList.Models;
using TodoList.Services.IService;
using TaskStatus = TodoList.Models.TaskStatus;

namespace TodoList.Services
{
    public class TodoTaskService : ITodoTaskService
    {
        private readonly TodoContext _context;

        public TodoTaskService(TodoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TodoTask>> GetAllTodoTasks()
        {
            return await _context.TodoTasks
                .Include(o => o.Staff)
                .Include(o => o.TodoTaskPartners)
                .ThenInclude(o => o.Staff)
                .ToListAsync();
        }

        public async Task<TodoTask> GetOneTodoTask(int id)
        {
            var todoTask = await _context.TodoTasks
                .Include(o => o.TodoTaskPartners)
                .Where(o => o.Id == id)
                .FirstOrDefaultAsync();
            return todoTask;
        }

        public TodoTask CreateTodoTask(string name, Staff staff)
        {
            TodoTask todoTask = new TodoTask
            {
                Name = name,
                StartDate = DateTime.Now,
                EndDate = (DateTime.Now).AddDays(7),
                Status = TaskStatus.InProgress,
                Access = TaskAccess.IsPrivate,
            };

            todoTask.StaffId = staff.Id;

            return todoTask;
        }

        public void AddTodoTask(TodoTask todoTask)
        {
            _context.Entry(todoTask).State = EntityState.Added;
        }

        public void UpdateTodoTask(TodoTask todoTask, int[] todoTaskPartnerIds)
        {
            _context.Entry(todoTask).State = EntityState.Modified;

            List<TodoTaskPartner> ogTodoTaskPartners = _context.TodoTaskPartners
                .Where(o => o.TodoTaskId == todoTask.Id).ToList();
            List<TodoTaskPartner> todoTaskPartners = todoTaskPartnerIds != null
                ? todoTaskPartnerIds
                    .Select(todoTaskPartnerId => new TodoTaskPartner
                    {
                        TodoTaskId = todoTask.Id, StaffId = todoTaskPartnerId
                    }).ToList()
                : new List<TodoTaskPartner>();

            foreach (TodoTaskPartner ogTodoTaskPartner in ogTodoTaskPartners)
            {
                _context.Entry(ogTodoTaskPartner).State = EntityState.Deleted;
            }

            foreach (TodoTaskPartner todoTaskPartner in todoTaskPartners)
            {
                _context.Entry(todoTaskPartner).State = EntityState.Added;
            }
        }

        public void DeleteTodoTask(TodoTask todoTask)
        {
            _context.Remove(todoTask);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}