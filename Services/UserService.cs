using System.Collections.Generic;
using System.Threading.Tasks;
using OktaFirst.Domain;

namespace OktaFirst.Services
{
    public interface UserService
    {
        Task<IList<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(string id);
        Task<User> CreateUser(User user);
    }
}