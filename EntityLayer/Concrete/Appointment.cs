using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string PatientPhone { get; set; }
        public string PatientIdentityNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
        public bool AppointmentStatus { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }









    }
}
