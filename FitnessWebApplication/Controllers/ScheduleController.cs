using FitnessWebApplication.Data.Services;
using FitnessWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly IScheduleServices _service;

        public ScheduleController(IScheduleServices service)
        {
            _service = service;

        }
        public async Task<IActionResult> Index()
        {
            var allSchedule = await _service.GetAllAsync(m=>m.Classes);
            return View(allSchedule);

        }

        //details
        public async Task<IActionResult> Details(int id)
        {

            var scheduleDetails = await _service.GetScheduleByIdAsync(id);

            if (scheduleDetails == null) return View("NotFound");
            return View(scheduleDetails);
        }

        //add
        public async Task<IActionResult> Create()
        {
            var scheduleDropdownvalues = await _service.GetScheduleDropDownValues();
            ViewBag.Classes = new SelectList(scheduleDropdownvalues.Classes, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ScheduleVM schedule)
        {
            if (!ModelState.IsValid)
            {
                return View(schedule);
            }
            await _service.AddScheduleAsync(schedule);
            return RedirectToAction(nameof(Index));
        }

    }
}
