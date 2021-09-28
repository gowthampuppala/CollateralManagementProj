using CollateralManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollateralManagement.Models
{
    public class CustomerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=KEERTHANA;Initial Catalog=CustomerDB;Integrated Security=True");
        }
        public DbSet<Collateral> collateral { get; set; }
        //public DbSet<Loan> Loans { get; set; }

    }
}
