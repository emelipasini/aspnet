using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Company.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display (Name = "Nombre")]
        [StringLength (20, MinimumLength = 2)]
        public string Firstname { get; set; }

        [Required]
        [Display (Name = "Apellido")]
        [StringLength(20, MinimumLength = 2)]
        public string Lastname { get; set; }

        [Display (Name = "Fecha de alta")]
        [DataType (DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [Display (Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }

        [Required]
        [Display (Name = "Faltas")]
        public int Absences { get; set; }

        [Required]
        [Display(Name = "Sueldo")]
        public int Salary { get; set; }

        [Required]
        [Display (Name = "Rol")]
        [StringLength(20, MinimumLength = 5)]
        public string Role { get; set; }

        public int GetYears(DateTime date)
        {
            int years = DateTime.Now.Subtract(date).Days;
            years /= 365;
            return years;
        }
    }


    public class CompanyDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}