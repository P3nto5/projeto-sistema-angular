using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agilAPI.Models;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace agilAPI.Data
{
    public class DatingRepository : IDatingRepository
    {
        private readonly DataContext _context;
        public DatingRepository(DataContext _context)
        {
            this._context = _context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<File> GetFile(int id)
        {
            var file = await _context.File.FirstOrDefaultAsync(p => p.Id == id);
            return file;
        }

        public Task<File> GetMainFileForUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Photo> GetMainPhotoForUser(int userId)
        {
            return await _context.Photos.Where(u => u.UserId == userId)
                .FirstOrDefaultAsync(p => p.IsMain);
        }

        public async Task<Photo> GetPhoto(int id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);
            return photo; 
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(p => p.Photos ).FirstOrDefaultAsync(u => u.Id == id);// o dia que deu capim 03/04/2019
          //  var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.Include(p => p.Photos).ToListAsync(); // o dia que deu capim 03/04/2019
          //  var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}