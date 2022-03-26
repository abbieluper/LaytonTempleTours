using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LaytonTempleTours.Models;
using Microsoft.EntityFrameworkCore;

namespace LaytonTempleTours.Controllers
{
    public class HomeController : Controller
    {
        private IAppointmentRepository repo;

        public HomeController(IAppointmentRepository temp)
        {
            repo = temp;
        }

        // DISPLAY THE HOME PAGE 
        public IActionResult Index()
        {
            return View();
        }

        // DISPLAY TIMES TO SIGN UP FOR AN APPOINTMENT
        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.FirstDay = new DateTime(2022, 3, 20);

            var times = repo.Times
                .OrderBy(x => x.TimeId)
                .ToList();

            return View(times);
        }

        // ADD NEW TEMPLE TOUR APPOINTMENTS
        [HttpGet]
        public IActionResult NewAppointment(int timeId)
        {
            ViewBag.AppointmentTime = repo.Times.Single(x => x.TimeId == timeId);

            return View(new Appointment());
        }

        [HttpPost]
        public IActionResult NewAppointment(Appointment app)
        {
            if (ModelState.IsValid)
            {
                Time time = repo.Times.FirstOrDefault(x => x.TimeId == app.TimeId);
                time.SlotAvailable = false;

                repo.CreateAppointment(app);

                repo.SaveTimeslot(time);

                return View("Index");
            }
            else // if invalid
            {
                ViewBag.AppointmentTime = repo.Times.Single(x => x.TimeId == app.TimeId);
                return View(app);
            }
        }

        // VIEW APPOINTMENTS
        [HttpGet]
        public IActionResult Appointments()
        {
            var apps = repo.Appointments
                .Include(x => x.Time)
                .OrderBy(x => x.TimeId)
                .ToList();

            return View(apps);
        }

        // EDIT APPOINTMENTS 
        [HttpGet]
        public IActionResult Edit(int appid)
        {
            var app = repo.Appointments.Single(x => x.AppointmentId == appid);
            ViewBag.AppointmentTime = repo.Times.Single(x => x.TimeId == app.TimeId);

            return View("NewAppointment", app);
        }

        [HttpPost]
        public IActionResult Edit(Appointment app)
        {
            if (ModelState.IsValid)
            {
                repo.SaveAppointment(app);

                return RedirectToAction("Appointments");
            }
            else // if invalid
            {
                ViewBag.AppointmentTime = repo.Times.Single(x => x.TimeId == app.TimeId);
                return View("NewAppointment", app);
            }

        }

        // DELETE APPOINTMENTS
        [HttpGet]
        public IActionResult Delete(int appid)
        {
            var app = repo.Appointments.Single(x => x.AppointmentId == appid);

            return View(app);
        }

        [HttpPost]
        public IActionResult Delete(Appointment app)
        {
            Appointment appChange = repo.Appointments.Single(x => x.AppointmentId == app.AppointmentId);
            Time time = repo.Times.FirstOrDefault(x => x.TimeId == appChange.TimeId);
            time.SlotAvailable = true;

            repo.DeleteAppointment(appChange);

            repo.SaveTimeslot(time);

            return View("Index");
        }
    }
}
