﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourDuLich_GUI.DAL;
using TourDuLich_GUI.Models;

namespace TourDuLich_GUI.BUS
{
    public class TourBUS
    {
        public static async Task<List<Tour>> GetAll()
        {
            var ctx = new TourContext();

            List<Tour> result = await ctx.Set<Tour>().ToListAsync();

            return result;
        }
        public static async Task<Tour> GetOne(int id)
        {
            var ctx = new TourContext();

            Tour result = await ctx.Set<Tour>()
                .Include(o => o.TourType)
                .FirstOrDefaultAsync(o => o.ID == id);

            return result;
        }
    }
}
