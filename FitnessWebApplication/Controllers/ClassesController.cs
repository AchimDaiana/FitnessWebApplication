using FitnessWebApplication.Data;
using FitnessWebApplication.Data.Services;
using FitnessWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Controllers
{
    public class ClassesController : Controller
    {
        private readonly IClassesServices _service;

        public ClassesController(IClassesServices service)
        {
            _service = service;
        }
         
        public async Task<IActionResult> Index()
        {
            var allClasses = await _service.GetAllAsync(m=>m.Trainer);
            return View(allClasses);
        }

        //Detaliile despre clase
        public async Task<IActionResult> Details(int id)
        {
            var classDetail = await _service.GetClassesByIdAsync(id);
            return View(classDetail);
        }

        //get:crearea claselor noi
        public async Task<IActionResult> Create()
        {
            var classDropdownvalues = await _service.GetClassDropdownValues();
            ViewBag.Trainers = new SelectList(classDropdownvalues.Trainers, "Id", "FirstName");
            return View();
        }

        //creare dar cu argumente
        [HttpPost]
        public async Task<IActionResult> Create(ClassVM classes)
        {
            if (!ModelState.IsValid)
            {
                var classDropdownvalues = await _service.GetClassDropdownValues();
                ViewBag.Trainers = new SelectList(classDropdownvalues.Trainers, "Id", "FirstName");
                return View(classes);
            }

            await _service.AddClassAsync(classes);
            return RedirectToAction(nameof(Index));
        }


        //get:editarea claselor 
        public async Task<IActionResult> Edit(int id)
        {
            var classDetails = await _service.GetByIdAsync(id);
            if (classDetails == null) return View("NotFound");

            var outcome = new ClassVM();
            outcome.Id = classDetails.Id;
            outcome.Name = classDetails.Name;
            outcome.PictureUrl = classDetails.PictureUrl;
            outcome.Description = classDetails.Description;
            outcome.TrainerId = classDetails.TrainerId;
            outcome.ClassCategory = classDetails.ClassCategory;


            //data pt dropdowns
            var classDropdownvalues = await _service.GetClassDropdownValues();
            ViewBag.Trainers = new SelectList(classDropdownvalues.Trainers, "Id", "FirstName");
            return View(outcome);
        }

        //creare dar cu argumente
        [HttpPost]
        public async Task<IActionResult> Edit(int id, ClassVM classes)
        {
            if (id != classes.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var classDropdownvalues = await _service.GetClassDropdownValues();
                ViewBag.Trainers = new SelectList(classDropdownvalues.Trainers, "Id", "FirstName");
                return View(classes);
            }

            await _service.UpdateClassAsync(classes);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
