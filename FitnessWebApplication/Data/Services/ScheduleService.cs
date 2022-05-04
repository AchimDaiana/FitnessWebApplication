using FitnessWebApplication.Data.BaseRepositories;
using FitnessWebApplication.Data.ViewModels;
using FitnessWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data.Services
{
    public class ScheduleService:EntityBaseRepository<Schedule>, IScheduleServices
    {
        private readonly AppDbContext _context;

        public ScheduleService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddScheduleAsync(ScheduleVM data)
        {
            var newSchedule = new Schedule();
            newSchedule.StartHour = data.StartHour;
            newSchedule.EndHour = data.EndHour;
            

            await _context.Schedules.AddAsync(newSchedule);
            await _context.SaveChangesAsync();

            List<Classes> listaClase = new List<Classes>();

            foreach ( var classID in data.ClassesIds)
            {
                Classes c = data.getClassesById(classID);


                listaClase.Add(c);
            }
            /*
                        foreach (var classesId in data.ClassesIds)
                        {
                            var newClassesSchedule = new Classes()
                            {
                                Id = classesId
                            };
                            await _context.Classes.AddAsync(newClassesSchedule);
                        }
                        await _context.SaveChangesAsync();*/

        }

        public async Task<Schedule> GetScheduleByIdAsync(int id)
        {
            var scheduleDetails = _context.Schedules.Include(b => b.Classes).FirstOrDefaultAsync(m => m.Id == id);
            return await scheduleDetails;
        }

        public async Task<ScheduleDropDownVm> GetScheduleDropDownValues()
        {
            var outcome = new ScheduleDropDownVm();
            outcome.Classes = await _context.Classes.OrderBy(m => m.Name).ToListAsync();
            return outcome;
        }
    }
}
