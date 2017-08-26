using System;
using System.Collections.Generic;
using GiveAShitBackend.Database.Models;

namespace GiveAShitBackend.Services
{
    public interface IUserService
    {
        User GetUser(int user);
        User GetUserByCardID(string user);
        void AddUser(User user);
    }
}