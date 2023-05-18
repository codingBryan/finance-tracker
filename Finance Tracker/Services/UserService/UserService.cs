using Finance_Tracker.Models;
using SQLite;
using System.Diagnostics;

namespace Finance_Tracker.Services.UserService
{
    public class UserService : IUserRepository
    {
        private SQLiteAsyncConnection database;
        public UserService()
        {

        }

         async Task Init()
        {
            if (database is not null) return;
            database = new SQLiteAsyncConnection(Constants.DatabasePath,Constants.Flags);
            var users=await database.CreateTableAsync<User>();

        }

        public async Task<int> Register(User user)
        {
            await Init();
            if(user.Id != 0)
            {
                return await database.UpdateAsync(user);
            }

            return await database.InsertAsync(user);
            Debug.WriteLine("uSER cREATED");

        }

        public async Task<User> Login(string username, string password)
        {
            await Init();
            try
            {
                var user = await database.Table<User>().Where(u => u.username == username).FirstOrDefaultAsync();
                if (user is null)
                {
                    throw new Exception("User not found");
                    return null;
                }
                if (user.password==password)
                {
                    return user;
                }
                else
                {
                    throw new Exception("Incorrect password");
                    return null;
                }

            }catch (Exception ex) 
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
