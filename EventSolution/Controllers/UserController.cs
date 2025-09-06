using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EventSolution.Models;

namespace EventSolution.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet("AllUsers")]
        public IActionResult AllUsers()
        {
            var users = AllUserList();
            return View("Users", users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }


        private List<UserViewModel> AllUserList()
        {
            List<UserViewModel> users = new List<UserViewModel>();

            UserViewModel user1 = new UserViewModel()
            {
                FirstName = "John",
                LastName = "Doe",
                ContactNumber = "123-456-7890",
                Email = "john@gmail.com",
                UserType = (UserType)1
            };
            UserViewModel user2 = new UserViewModel()
            {
                FirstName = "Jane",
                LastName = "Smith",
                ContactNumber = "987-654-3210",
                Email = "jane@gmail.com",
                UserType = (UserType)2
            };
            UserViewModel user3 = new UserViewModel()
            {
                FirstName = "Alice",
                LastName = "Johnson",
                ContactNumber = "555-123-4567",
                Email = "alice@gmail.com",
                UserType = (UserType)3
            };
            UserViewModel user4 = new UserViewModel()
            {
                FirstName = "Bob",
                LastName = "Brown",
                ContactNumber = "444-987-6543",
                Email = "bob@gmail.com",
                UserType = (UserType)4
            };
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            return users;

        }
    }
}