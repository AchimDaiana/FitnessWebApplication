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
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //creare antrenor
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Biography,ProfilePictureUrl")]Trainer trainer)
        {
            if (!ModelState.IsValid)
            {
                return View(trainer);
            }
            
            await _service.AddAsync(trainer);
            return RedirectToAction(nameof(Index));
        }

        //detalii antrenor
        public async Task<IActionResult> Details(int id)
        {
            var trDetails = await _service.GetByIdAsync(id);

            if (trDetails == null) return View("NotFound");
            return View(trDetails);

        }

        //editare antrenor
        public async Task <IActionResult> Edit(int id)
        {
            var trDetails = await _service.GetByIdAsync(id);
            if (trDetails == null) return View("NotFound");
            return View(trDetails);
        }

        [HttpPost]
        
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Biography,ProfilePictureUrl")] Trainer trainer)
        {
            if (!ModelState.IsValid)
            {
                return View(trainer);
            }

            await _service.UpdateAsync(id,trainer);
            return RedirectToAction(nameof(Index));
        }

        //stergere antrenor
        public async Task<IActionResult> Delete(int id)
        {
            var trDetails = await _service.GetByIdAsync(id);
            if (trDetails == null) return View("NotFound");
            return View(trDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteValidation(int id)
        {
            var trDetails = await _service.GetByIdAsync(id);
            if (trDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }   
    
}
