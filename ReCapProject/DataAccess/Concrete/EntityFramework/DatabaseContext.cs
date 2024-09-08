using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // Context object is used to connect database and project classes.
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We specify that we will use SQL server.
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Database=RentACar;Trusted_Connection=true");
        }

        // With the following props, we establish the connection between the Database tables and the Entities we create.
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Color> Color { get; set; }
    }
}
