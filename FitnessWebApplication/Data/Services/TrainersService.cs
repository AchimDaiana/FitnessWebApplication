using FitnessWebApplication.Data.BaseRepositories;
using FitnessWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data.Services
{
    public class TrainersService :EntityBaseRepository<Trainer>, ITrainersServices
    {
        

        public TrainersService(AppDbContext context) : base(context) { }
        
        
    }
}
