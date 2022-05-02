using FitnessWebApplication.Data.BaseRepositories;
using FitnessWebApplication.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Models
{
    public class ClassVM
    {
        public int Id { get; set; }

        [Display(Name = "Numele clasei")]
        [Required(ErrorMessage = "Campul Numele clasei trebuie completat obligatoriu!")]
        public string Name { get; set; }

        [Display(Name = "Descriere")]
        [Required(ErrorMessage = "Campul Descriere trebuie completat obligatoriu!")]
        public string Description { get; set; }

        [Display(Name = "UrlPoza")]
        [Required(ErrorMessage = "Campul Poza trebuie completat obligatoriu!")]
        public string PictureUrl { get; set; }

        [Display(Name = "Categoria Clasei")]
        public ClassCategory ClassCategory { get; set; }

        public List<int> ReservationIds { get; set; }

        [Display(Name = "Antrenorul  clasei")]
        public int TrainerId { get; set; }
        


    }
}
