using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
    }
}
