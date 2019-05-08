using agilAPI.Models;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace agilAPI.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options){

        }
        public DbSet<Person> Persons{get; set;}
        public DbSet<User> Users{ get; set;}
        public DbSet<Photo> Photos { get; set; }
        public DbSet<File> File { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        //public Dbset<File> MyProperty { get; set; }
      
    }
}