using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Identity.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [StringLength(140, MinimumLength = 5)]
        public string Description { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}