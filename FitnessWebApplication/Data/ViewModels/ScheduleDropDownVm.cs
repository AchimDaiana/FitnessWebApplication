using FitnessWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data.ViewModels
{
    public class ScheduleDropDownVm
    {
        public ScheduleDropDownVm()
        {
            Classes = new List<Classes>();
        }
        public List<Classes> Classes { get; set; }
    }
}
