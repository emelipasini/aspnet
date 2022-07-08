using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public int ClientId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [StringLength(140, MinimumLength = 5)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Repository")]
        public string Repository { get; set; }

        [Required]
        [Display(Name = "Board")]
        public string Board { get; set; }

        [Display(Name = "Deploy")]
        public string Deploy { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual Client Client { get; set; }
    }
}