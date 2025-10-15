using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace FixItNow.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public ServiceCategory Category { get; set; }

        // New fields for rating, duration, and insurance
        [Range(0, 5)]
        public double Rating { get; set; } = 0;

        // Duration in hours (e.g., 2.5 for 2 hours 30 minutes)
        [Display(Name = "Duration (hours)")]
        public double Duration { get; set; } = 1;

        // Insurance information (e.g., "Covered", "Not Covered", or details)
        public string Insurance { get; set; }

        public ICollection<ServiceRequest> ServiceRequests { get; set; }
    }
}
