using FitnessWebApplication.Data.BaseRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Models
{
    public class ScheduleVM 
    {
        [Display(Name = "Ora start")]
        public DateTime StartHour { get; set; }

        [Display(Name = "Ora finish")]
        public DateTime EndHour { get; set; }

        //relatia cu clasele
        public List<int> ClassesIds { get; set; }
        


    }
}
