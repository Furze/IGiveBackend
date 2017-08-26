using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiveAShitBackend.Database.Models;
using GiveAShitBackend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Internal.System.Collections.Sequences;

namespace GiveAShitBackend.Controllers
{
    [Route("api/[controller]")]

    // api/users
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }


        // POST api/users
        [HttpPost]
        public void Post([FromBody] User User)
        {
            userService.AddUser(User);
        }

        // GET api/products?userId=
        [HttpGet]
        [Route("GetByID")]
        public User Get([FromQuery] int userId)
        {
            return userService.GetUser(userId);
        }

        // GET api/products?userId=
        [HttpGet]
        [Route("GetByCard")]
        public User Get([FromQuery] string cardId)
        {
            return userService.GetUserByCardID(cardId);
        }
    }
}