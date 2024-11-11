using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // Context object is used to connect database and project classes.
    public class NorthwindContext : DbContext
    {
        // This method allows us to specify which database our project is associated with.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We specify that we will use SQL server.
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Database=master;Trusted_Connection=true");
        }

        // With the following props, we establish the connection between the Database tables and the Entities we create.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
