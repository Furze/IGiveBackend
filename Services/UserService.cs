using GiveAShitBackend.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiveAShitBackend.Database.Models;

namespace GiveAShitBackend.Services
{

   
    public class UserService : IUserService
    {
        GASDbContext _dbcontext;

        public UserService(GASDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void AddUser(User user)
        {
            _dbcontext.Users.Add(user);
            _dbcontext.SaveChanges();
        }

        public User GetUser(int userId)
        {
           var userToGet = _dbcontext.Users.First(x => x.Id == userId);
            return userToGet;
        }
    }
}
