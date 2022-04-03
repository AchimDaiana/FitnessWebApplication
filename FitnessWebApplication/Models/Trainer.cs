using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }

        [Required(ErrorMessage ="Biography is required")]
        public string Biography { get; set; }

        //relatia antrenori cu clase
        public int ClassesId { get; set; }
        public Classes Classes { get; set; }

    }
}
