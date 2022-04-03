using FitnessWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data.Services
{
    public interface ITrainersServices
    {
        Task<IEnumerable<Trainer>> GetAll();

        Trainer GetById(int id);

        void Add(Trainer trainer);

        Trainer Update(int id, Trainer newTrainer);

        void Delete(int id);

    }
}
