using System;
using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int ProjectId { get; set; }

        [Required]
        [Display(Name = "Firstname")]
        [StringLength(20, MinimumLength = 2)]
        public string Firstname { get; set; }

        [Required]
        [Display(Name = "Lastname")]
        [StringLength(20, MinimumLength = 2)]
        public string Lastname { get; set; }

        [Display(Name = "Registration date")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }

        [Required]
        [Display(Name = "Absences")]
        public int Absences { get; set; }

        [Required]
        [Display(Name = "Salary")]
        public int Salary { get; set; }

        [Required]
        [Display(Name = "Role")]
        [StringLength(20, MinimumLength = 5)]
        public string Role { get; set; }

        public int GetYears(DateTime date)
        {
            int years = DateTime.Now.Subtract(date).Days;
            years /= 365;
            return years;
        }

        public virtual Project Project { get; set; }
    }
}