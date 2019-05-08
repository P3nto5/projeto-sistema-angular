using System.Collections.Generic;
using System.Threading.Tasks;
using agilAPI.Models;
using DatingApp.API.Models;

namespace agilAPI.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
         Task<File> GetFile(int id);
         Task<File> GetMainFileForUser(int userId);

    }
}