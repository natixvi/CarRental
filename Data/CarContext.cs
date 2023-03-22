using CarRental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
         : base(options) 
        { 
        }

        public DbSet<CarRental.Models.Car> Car { get; set; }
       public DbSet<CarRental.Models.Category> Category { get; set; }

       public DbSet<CarRental.Models.Customer> Customer { get; set; }
       public DbSet<CarRental.Models.Rental> Rental { get; set; }

    }
    
}
