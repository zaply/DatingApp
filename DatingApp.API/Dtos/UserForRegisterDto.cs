using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="You must specify password between 4 and 8 characters")]
        public string Password { get; set; }
        [Required]
        public string Sesso { get; set; }
        [Required]
        public string KnowAs { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastActive { get; set; }
        public UserForRegisterDto() {
            CreatedAt = DateTime.Now;
            LastActive = DateTime.Now;            
        }
    }
}