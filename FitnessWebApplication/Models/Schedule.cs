using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        //public string Training { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }

        //relatia cu clasele
        public List<Classes> Trainings { get; set; }


    }
}
