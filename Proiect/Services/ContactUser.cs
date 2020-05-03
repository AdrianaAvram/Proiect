using Proiect.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Services
{
    public class ContactUser: IContactUser
    {

          readonly SQLiteAsyncConnection sqliteconnection;
          public ContactUser(string dbPath)
          {
              sqliteconnection = new SQLiteAsyncConnection(dbPath);
              sqliteconnection.CreateTableAsync<User>().Wait();
          }

        public ContactUser()
        {
        }

        public async Task<User> GetUser(int id)
          {
              return await sqliteconnection.Table<User>()
              .Where(i => i.Id == id)
             .FirstOrDefaultAsync();
          }
          public async Task AddUser(User user)
          {
              await sqliteconnection.InsertAsync(user);
          }
          public async Task DeleteUser(User user)
          {
              await sqliteconnection.DeleteAsync(user);
          }

          public async Task AdminUser()
          {
              await sqliteconnection.QueryAsync<User>("SELECT * FROM User WHERE Id==1");
          }

       public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await sqliteconnection.Table<User>().ToListAsync();
        }

    }
}
