using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FixItNow.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [Phone]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(200)]
        public string PasswordHash { get; set; }

        public bool IsAdmin { get; set; }

        public ICollection<ServiceRequest> ServiceRequests { get; set; }
    }
}

