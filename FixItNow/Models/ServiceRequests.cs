using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FixItNow.Models
{
    public class ServiceRequest
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Requested Service")]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Preferred Date")]
        public DateTime PreferredDate { get; set; } = DateTime.Today;

        [Display(Name = "Preferred Time")]
        public string PreferredTime { get; set; }

        public string Status { get; set; } = "Pending";

        public int? UserId { get; set; }
        public User User { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal EstimatedPrice { get; set; }

        public string Notes { get; set; }
    }
}
