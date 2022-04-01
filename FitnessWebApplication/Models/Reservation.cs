using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Hour { get; set; }
        public  DateTime DateParticipation { get; set; }

        //relatia rezervarilor cu userii
        public List<User> Users { get; set; }

        //relatia rezervarilor cu clasele
        public List<Classes> Classes { get; set; }


    }
}
