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

        
        public IActionResult SignUp()
        {
            var apts = AptContext.Appointments
                .Where(x => x.Filled == false)
                .ToList();
            return View(apts);
        }


        [HttpGet]
        public IActionResult BookAppointment(int appointmentid)
        {
            var apt = AptContext.Appointments
                .Single(x => x.AppointmentId == appointmentid);
            return View(apt);

            //form has to have a hidden field that is the apointment ID


        }

        [HttpPost]
        public IActionResult BookAppointment(Groups grp)
        {
            if (ModelState.IsValid)
            {
                AptContext.Add(grp);
                AptContext.SaveChanges();
                return RedirectToAction("Appointments");
            }
            else
            {
                return View(grp);
            }
        }



        public IActionResult Appointments()
        {
            var groups = AptContext.Groups
                .Include(x => x.Appointment)
                .Where(x => x.Appointment.Filled == true)
                .ToList();
            return View(groups);
        }

        [HttpGet]
        public IActionResult Edit(int groupid)
        {
            var grp = AptContext.Groups
                .Include(x => x.Appointment)
                .Single(x => x.GroupId == groupid);
            return View("BookAppointment", grp);
        }

        [HttpPost]
        public IActionResult Edit(Groups grp)
        {
            AptContext.Update(grp);
            AptContext.SaveChanges();

            return RedirectToAction("Appointments");
        }



        [HttpPost]
        public IActionResult Delete(int groupid)
        {
            var gro = AptContext.Groups.Single(x => x.GroupId == groupid);
            AptContext.Appointments.Single(x => x.AppointmentId == gro.AppointmentId).Filled = false;
            AptContext.Groups.Remove(gro);
            AptContext.SaveChanges();
            return RedirectToAction("Appointments");
        }
    }
}
