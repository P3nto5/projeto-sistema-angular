using System.Threading.Tasks;
using agilAPI.Models;
using DatingApp.API.Models;

namespace agilAPI.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> UserExists(string username);

        Task<bool> CpfExists(string cpf);
        Task<bool> EmailExists(string email);
    }
}