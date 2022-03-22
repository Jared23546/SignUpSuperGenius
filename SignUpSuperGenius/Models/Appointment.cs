using System;
using System.ComponentModel.DataAnnotations;

namespace SignUpSuperGenius.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentId { get; set; }

        [Required]
        public string Day { get; set; }

        [Required]
        public string Time { get; set; }

        public bool Filled { get; set; }
    }
}
