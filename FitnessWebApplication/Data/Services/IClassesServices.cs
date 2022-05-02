using FitnessWebApplication.Data.BaseRepositories;
using FitnessWebApplication.Data.ViewModels;
using FitnessWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data.Services
{
    public interface IClassesServices:IEntityBaseRepository<Classes>
    {
        Task<Classes> GetClassesByIdAsync(int id);
        Task<ClassDropdownVM> GetClassDropdownValues();
        Task AddClassAsync(ClassVM data);
        Task UpdateClassAsync(ClassVM data);
       
    }
}
