using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Seeders
{
    public class UserSeeder
    {
        private readonly UserManager<User> _userManager;
        public UserSeeder(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task SeedUsers()
        {
            var users = new List<User>()
            {
                new() {Id = "bob-id", Email = "bob@gmail.com", UserName = "bob@gmail.com"},
                new() {Id = "tom-id", Email = "tom@gmail.com", UserName = "tom@gmail.com"},
                new() {Id = "ann-id", Email = "ann@gmail.com", UserName = "ann@gmail.com"},
            };

            foreach (var user in users)
            {
                if (await _userManager.FindByIdAsync(user.Id) == null)
                {
                    await _userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }
        }
    }
}
