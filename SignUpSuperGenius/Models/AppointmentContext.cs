using System;
using Microsoft.EntityFrameworkCore;

namespace SignUpSuperGenius.Models
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {
            //Leave blank
        }

        public DbSet<Appointment> Appointments { get; set; }
        //public DbSet<Groups> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Appointment>().HasData(

                new Appointment
                {
                    AppointmentId = 1,
                    Day = "Monday",
                    Time = "8:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 2,
                    Day = "Monday",
                    Time = "9:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 3,
                    Day = "Monday",
                    Time = "10:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 4,
                    Day = "Monday",
                    Time = "11:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 5,
                    Day = "Monday",
                    Time = "12:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 6,
                    Day = "Monday",
                    Time = "1:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 7,
                    Day = "Monday",
                    Time = "2:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 8,
                    Day = "Monday",
                    Time = "3:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 9,
                    Day = "Monday",
                    Time = "4:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 10,
                    Day = "Monday",
                    Time = "5:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 11,
                    Day = "Monday",
                    Time = "6:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 12,
                    Day = "Monday",
                    Time = "7:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 13,
                    Day = "Monday",
                    Time = "8:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 14,
                    Day = "Tuesday",
                    Time = "8:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 15,
                    Day = "Tuesday",
                    Time = "9:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 16,
                    Day = "Tuesday",
                    Time = "10:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 17,
                    Day = "Tuesday",
                    Time = "11:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 18,
                    Day = "Tuesday",
                    Time = "12:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 19,
                    Day = "Tuesday",
                    Time = "1:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 20,
                    Day = "Tuesday",
                    Time = "2:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 21,
                    Day = "Tuesday",
                    Time = "3:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 22,
                    Day = "Tuesday",
                    Time = "4:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 23,
                    Day = "Tuesday",
                    Time = "5:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 24,
                    Day = "Tuesday",
                    Time = "6:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 25,
                    Day = "Tuesday",
                    Time = "7:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 26,
                    Day = "Tuesday",
                    Time = "8:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 27,
                    Day = "Wednesday",
                    Time = "8:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 28,
                    Day = "Wednesday",
                    Time = "9:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 29,
                    Day = "Wednesday",
                    Time = "10:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 30,
                    Day = "Wednesday",
                    Time = "11:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 31,
                    Day = "Wednesday",
                    Time = "12:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 32,
                    Day = "Wednesday",
                    Time = "1:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 33,
                    Day = "Wednesday",
                    Time = "2:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 34,
                    Day = "Wednesday",
                    Time = "3:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 35,
                    Day = "Wednesday",
                    Time = "4:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 36,
                    Day = "Wednesday",
                    Time = "5:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 37,
                    Day = "Wednesday",
                    Time = "6:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 38,
                    Day = "Wednesday",
                    Time = "7:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 39,
                    Day = "Wednesday",
                    Time = "8:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 40,
                    Day = "Thursday",
                    Time = "8:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 41,
                    Day = "Thursday",
                    Time = "9:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 42,
                    Day = "Thursday",
                    Time = "10:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 43,
                    Day = "Thursday",
                    Time = "11:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 44,
                    Day = "Thursday",
                    Time = "12:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 45,
                    Day = "Thursday",
                    Time = "1:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 46,
                    Day = "Thursday",
                    Time = "2:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 47,
                    Day = "Thursday",
                    Time = "3:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 48,
                    Day = "Thursday",
                    Time = "4:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 49,
                    Day = "Thursday",
                    Time = "5:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 50,
                    Day = "Thursday",
                    Time = "6:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 51,
                    Day = "Thursday",
                    Time = "7:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 52,
                    Day = "Thursday",
                    Time = "8:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 53,
                    Day = "Friday",
                    Time = "8:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 54,
                    Day = "Friday",
                    Time = "9:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 55,
                    Day = "Friday",
                    Time = "10:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 56,
                    Day = "Friday",
                    Time = "11:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 57,
                    Day = "Friday",
                    Time = "12:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 58,
                    Day = "Friday",
                    Time = "1:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 59,
                    Day = "Friday",
                    Time = "2:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 60,
                    Day = "Friday",
                    Time = "3:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 61,
                    Day = "Friday",
                    Time = "4:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 62,
                    Day = "Friday",
                    Time = "5:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 63,
                    Day = "Friday",
                    Time = "6:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 64,
                    Day = "Friday",
                    Time = "7:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 65,
                    Day = "Friday",
                    Time = "8:00pm",
                    Filled = false,
                },
                new Appointment
                {
                AppointmentId = 66,
                    Day = "Saturday",
                    Time = "8:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 67,
                    Day = "Saturday",
                    Time = "9:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 68,
                    Day = "Saturday",
                    Time = "10:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 69,
                    Day = "Saturday",
                    Time = "11:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 70,
                    Day = "Saturday",
                    Time = "12:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 71,
                    Day = "Saturday",
                    Time = "1:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 72,
                    Day = "Saturday",
                    Time = "2:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 73,
                    Day = "Saturday",
                    Time = "3:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 74,
                    Day = "Saturday",
                    Time = "4:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 75,
                    Day = "Saturday",
                    Time = "5:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 76,
                    Day = "Saturday",
                    Time = "6:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 77,
                    Day = "Saturday",
                    Time = "7:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 78,
                    Day = "Saturday",
                    Time = "8:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 79,
                    Day = "Sunday",
                    Time = "8:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 80,
                    Day = "Sunday",
                    Time = "9:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 81,
                    Day = "Sunday",
                    Time = "10:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 82,
                    Day = "Sunday",
                    Time = "11:00am",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 83,
                    Day = "Sunday",
                    Time = "12:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 84,
                    Day = "Sunday",
                    Time = "1:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 85,
                    Day = "Sunday",
                    Time = "2:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 86,
                    Day = "Sunday",
                    Time = "3:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 87,
                    Day = "Sunday",
                    Time = "4:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 88,
                    Day = "Sunday",
                    Time = "5:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 89,
                    Day = "Sunday",
                    Time = "6:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 90,
                    Day = "Sunday",
                    Time = "7:00pm",
                    Filled = false,
                },
                new Appointment
                {
                    AppointmentId = 91,
                    Day = "Sunday",
                    Time = "8:00pm",
                    Filled = false,
                }
            );
        }
    }
}