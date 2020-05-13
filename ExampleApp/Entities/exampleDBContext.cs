using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApp.Entities
{
    public class exampleDBContext : DbContext
    {
        public exampleDBContext(DbContextOptions<exampleDBContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
