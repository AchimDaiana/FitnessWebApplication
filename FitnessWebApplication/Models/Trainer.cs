using FitnessWebApplication.Data.BaseRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Models
{
    public class Trainer:IEntityBase
    {
        public int Id { get; set; }

        [Display(Name = "Prenume")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(10,MinimumLength = 3, ErrorMessage = "First Name must be between 3 and 10 characters!")]
        public string FirstName { get; set; }

        [Display(Name = "Nume")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 10 characters!")]
        public string LastName { get; set; }

        [Display(Name = "Poza de profil")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Biografie")]
        public string Biography { get; set; }

        //public int ClassesId { get; set; }
        //public Classes Classes { get; set; }

   

    }
}
