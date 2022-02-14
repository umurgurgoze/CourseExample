using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public string DoctorTitle { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public bool DoctorStatus { get; set; }

        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }

        public List<Appointment> Appointments { get; set; }


    }
}
