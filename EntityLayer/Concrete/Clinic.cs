using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Clinic
    {
        [Key]
        public int ClinicId { get; set; }
        public string ClinicName { get; set; }
        public bool ClinicStatus { get; set; }

        public List<Doctor> Doctors { get; set; }



    }
}
