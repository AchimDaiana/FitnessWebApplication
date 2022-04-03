using FitnessWebApplication.Data;
using FitnessWebApplication.Data.Services;
using FitnessWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Controllers
{
    public class TrainersController : Controller
    {
        private readonly ITrainersServices _service;

        public TrainersController(ITrainersServices service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Biography,Class,ProfilePictureUrl")]Trainer trainer)
        {
            if (!ModelState.IsValid)
            {
                return View(trainer);
            }
            
            _service.Add(trainer);
            return RedirectToAction(nameof(Index));
        }
    }
}
