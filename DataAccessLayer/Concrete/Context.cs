using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=Z29-9;Database=HospitalDatabase;User=z29;Password=11072010;");			
		}
		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<Clinic> Clinics{ get; set; }
		public DbSet<Doctor> Doctors { get; set; }
	}
}
