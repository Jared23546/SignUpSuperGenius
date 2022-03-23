using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SignUpSuperGenius.Models;

namespace SignUpSuperGenius.Controllers
{
    public class HomeController : Controller
    {
        private AppointmentContext AptContext { get; set; }

        public HomeController(AppointmentContext kuso)
        {
            AptContext = kuso;
        }

        public IActionResult Index()
        {

            return View();
        }

        //[HttpGet]
        public IActionResult SignUp()
        {
            var apts = AptContext.Appointments
                .Where(x => x.Filled == false)
                .ToList();
            return View(apts);
        }

        //[HttpPost]
        //public IActionResult SignUp(int appointmentid)

        [HttpGet]
        public IActionResult BookAppointment(int appointmentid)
        {
            var apt = AptContext.Appointments
                .Single(x => x.AppointmentId == appointmentid);
            
            return View(apt);

            //form has to have a hidden field that is the apointment ID


        }

        [HttpPost]
        public IActionResult BookAppointment(Appointment apt)
        {
            if (ModelState.IsValid)
            {
                AptContext.Update(apt);
                AptContext.SaveChanges();
                return RedirectToAction("Appointments");
            }
            else
            {
                return View(apt);
            }
        }



        public IActionResult Appointments()
        {
            var apts = AptContext.Appointments
                //.Include(x => x.Appointment)
                .Where(x => x.Filled == true)
                .ToList();
            return View(apts);
        }

        [HttpGet]
        public IActionResult Edit(int appointmentid)
        {
            var apt = AptContext.Appointments
                //.Include(x => x.Appointment)
                .Single(x => x.AppointmentId == appointmentid);
            return View("BookAppointment", apt);
        }

        [HttpPost]
        public IActionResult Edit(Appointment apt)
        {
            AptContext.Update(apt);
            AptContext.SaveChanges();

            return RedirectToAction("Appointments");
        }



        [HttpPost]
        public IActionResult Delete(int appointmentid)
        {
            var apt = AptContext.Appointments.Single(x => x.AppointmentId == appointmentid);
            AptContext.Appointments.Single(x => x.AppointmentId == apt.AppointmentId).Filled = false;
            AptContext.Appointments.Single(x => x.AppointmentId == apt.AppointmentId).Name = "";
            AptContext.Appointments.Single(x => x.AppointmentId == apt.AppointmentId).Size = 0;
            AptContext.Appointments.Single(x => x.AppointmentId == apt.AppointmentId).Email = "";
            AptContext.Appointments.Single(x => x.AppointmentId == apt.AppointmentId).PhoneNumber = "";
            //AptContext.Remove(apt);
            AptContext.SaveChanges();
            return RedirectToAction("Appointments");
        }
    }
}
