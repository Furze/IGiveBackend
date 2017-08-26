using System;
using System.Collections.Generic;
using GiveAShitBackend.Database.Models;

namespace GiveAShitBackend.Services
{
    public interface IUserService
    {
        User GetUser(int userId);
        void AddUser(User user);
    }
}