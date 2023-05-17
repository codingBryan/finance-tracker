using Finance_Tracker.Models;
using SQLite;
using System.Diagnostics;

namespace Finance_Tracker.Services.UserService
{
    public class UserService : IUserRepository
    {
        protected readonly SQLiteAsyncConnection database;
        public UserService( string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }
        public async Task<User> AddUpdateUser(User user)
        {
            User newUser=new();
            try
            {
                if (user.Id > 0)
                {
                   await database.UpdateAsync(user);
                   return await database.FindAsync<User>(user);
                }
                await database.InsertAsync(user);
                return await database.FindAsync<User>(user);


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: ",ex.Message);
            }
            return await database.FindAsync<User>(user);

        }
    }
}
