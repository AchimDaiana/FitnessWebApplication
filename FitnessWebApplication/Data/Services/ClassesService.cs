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
    public class ClassesService : EntityBaseRepository<Classes>, IClassesServices
    {
        private readonly AppDbContext _context;
        public ClassesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddClassAsync(ClassVM data)
        {
            var newClass = new Classes();
            newClass.Name = data.Name;
            newClass.Description = data.Description;
            newClass.PictureUrl = data.PictureUrl;
            newClass.TrainerId = data.TrainerId;
            newClass.ClassCategory = data.ClassCategory;

            await _context.Classes.AddAsync(newClass);
            await _context.SaveChangesAsync();

          

        }

        public async Task<ClassDropdownVM> GetClassDropdownValues()
        {
            var outcome = new ClassDropdownVM();
            outcome.Trainers = await _context.Trainers.OrderBy(m => m.FirstName).ToListAsync();
            return outcome;
        }

        public async Task<Classes> GetClassesByIdAsync(int id)
        {
            var classDetails = _context.Classes.Include(b => b.Trainer).FirstOrDefaultAsync(m => m.Id == id);

            return await classDetails;
        }

        public async Task UpdateClassAsync(ClassVM data)
        {
            var dbClasses = await _context.Classes.FirstOrDefaultAsync(m => m.Id == data.Id);
            
            if(dbClasses != null)
            {
                dbClasses.Name = data.Name;
                dbClasses.Description = data.Description;
                dbClasses.PictureUrl = data.PictureUrl;
                dbClasses.TrainerId = data.TrainerId;
                dbClasses.ClassCategory = data.ClassCategory;
                await _context.SaveChangesAsync();
            }
            
        }

       
    }
}
