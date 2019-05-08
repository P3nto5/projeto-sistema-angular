using System;
using System.Collections.Generic;
using agilAPI.Models;

namespace agilAPI.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
         public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
         public string CEP { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string Number { get; set; }
       public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
        public ICollection<FilesForDetailedDto> Files { get; set; }
        
    }
}