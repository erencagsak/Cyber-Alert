using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class DataContext:DbContext
    {
        public DbSet<CyberAttacks> CyberAttacks { get; set; }
        public DbSet<WorldCountries> WorldCountries { get; set; }
        public DbSet<Phone> Phone{ get; set; }
        public DbSet<AboutUS> AboutUs{ get; set; }
        public DbSet<WorldToWorld> WorldToWorlds { get; set; }
    }
}
