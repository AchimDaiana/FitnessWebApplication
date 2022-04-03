using FitnessWebApplication.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Controllers
{
    public class TrainersController : Controller
    {
        private readonly AppDbContext _contex;

        public TrainersController(AppDbContext context)
        {
            _contex = context;
        }


        public IActionResult Index()
        {
            var data = _contex.Trainers.ToList();
            return View(data);
        }
    }
}
