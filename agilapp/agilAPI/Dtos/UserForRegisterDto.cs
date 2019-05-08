using System;
using System.ComponentModel.DataAnnotations;

namespace agilAPI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }       
         [Required]
         [StringLength(8,MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters" )]
        public string Password { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string RG { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
         public string Gender { get; set; }
         [Required]
        public string KnownAs { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
         public string CEP { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string Number { get; set; }
        public string Phone { get; set; }
        public string Telephone { get; set; }
        public UserForRegisterDto(){
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}