using backend.Models;
using System.Threading.Tasks;

namespace backend.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string Username, string password);
        Task<bool> UserExists(string username);
    }
}