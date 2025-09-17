using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Seeders
{
    public class DbSeeder
    {
        private readonly UserSeeder _userSeeder;
        public DbSeeder(UserSeeder userSeeder)
        {
            _userSeeder = userSeeder;
        }
        public async Task SeedData()
        {
            await _userSeeder.SeedUsers();
        }
    }
}
