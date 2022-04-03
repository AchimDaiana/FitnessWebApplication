using FitnessWebApplication.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public ClassCategory ClassCategory { get; set; }

        //relatia dintre clase si rezervari
        public List<Reservation> Reservations { get; set; }

        //relatia dintre clase si antrenori
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }


    }
}
