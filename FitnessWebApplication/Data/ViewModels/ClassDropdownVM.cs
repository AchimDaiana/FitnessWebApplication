using FitnessWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data.ViewModels
{
    public class ClassDropdownVM
    {
        public ClassDropdownVM()
        {
            Trainers = new List<Trainer>();
          
        }

        public List<Trainer> Trainers { get; set; }
        

    }
}
