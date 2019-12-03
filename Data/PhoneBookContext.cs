using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhoneBook.Models
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext (DbContextOptions<PhoneBookContext> options)
            : base(options)
        {
        }

        public DbSet<PhoneBook.Models.User> User { get; set; }
    }
}
