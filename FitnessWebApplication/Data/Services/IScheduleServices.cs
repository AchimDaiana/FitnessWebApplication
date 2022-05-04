using FitnessWebApplication.Data.BaseRepositories;
using FitnessWebApplication.Data.ViewModels;
using FitnessWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data.Services
{
    public interface IScheduleServices:IEntityBaseRepository<Schedule>
    {
        Task<Schedule> GetScheduleByIdAsync(int id);
        Task<ScheduleDropDownVm> GetScheduleDropDownValues();
        Task AddScheduleAsync(ScheduleVM data);
    }
}
