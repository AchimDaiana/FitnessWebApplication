using FitnessWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data.Services
{
    public class TrainersService : ITrainersServices
    {
        private readonly AppDbContext _context;

        public TrainersService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Trainer trainer)
        {
            _context.Trainers.Add(trainer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Trainer>> GetAll()
        {
            var result = await _context.Trainers.ToListAsync();
            return result;
        }

        public Trainer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Trainer Update(int id, Trainer newTrainer)
        {
            throw new NotImplementedException();
        }
    }
}
