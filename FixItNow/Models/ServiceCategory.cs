using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FixItNow.Models
{
    public class ServiceCategory
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}
