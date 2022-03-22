using System;
using System.ComponentModel.DataAnnotations;

namespace SignUpSuperGenius.Models
{
    public class Groups
    {
        [Key]
        [Required]
        public int GroupId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ushort Size { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        public string PhoneNumber { get; set; }
    }
}
