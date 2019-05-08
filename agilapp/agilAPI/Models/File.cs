using System;
using System.Text;
using agilAPI.Helpers;
using DatingApp.API.Models;

namespace agilAPI.Models
{
    public class File
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FileType FileType { get; set; }
        public string  ContentType { get; set; }
        public byte[] Content { get; set; }
        public long Lengh { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}