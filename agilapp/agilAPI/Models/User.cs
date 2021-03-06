using System;
using System.Collections;
using System.Collections.Generic;
using agilAPI.Models;

namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string CEP { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string Number { get; set; }
        public string Telephone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}