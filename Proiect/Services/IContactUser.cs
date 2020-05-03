using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Services
{
   public  interface IContactUser
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUser(int id);
        Task AddUser(User user);
        Task DeleteUser(User user);
        Task AdminUser();
    }
}
