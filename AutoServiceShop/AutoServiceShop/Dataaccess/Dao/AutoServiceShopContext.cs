using AutoServiceShop.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao
{
    public class AutoServiceShopContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AutoServiceShopDB;Integrated Security=True;MultipleActiveResultSets=True");
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Data.Entity.Account> Accounts { get; set; }

        public DbSet<Data.Entity.AccountStatus> AccountStatuses { get; set; }

        public DbSet<Data.Entity.AccountType> AccountTypes { get; set; }

        public DbSet<Data.Entity.AutoPart> AutoParts { get; set; }

        public DbSet<Data.Entity.AutoPartStatus> AutoPartStatuses { get; set; }

        public DbSet<Data.Entity.CheckUp> CheckUps { get; set; }

        public DbSet<Data.Entity.CheckUpStatus> CheckUpStatuses { get; set; }

        public DbSet<Data.Entity.Contract> Contracts { get; set; }

        public DbSet<Data.Entity.ContractStatus> ContractStatuses { get; set; }

        public DbSet<Data.Entity.ContractType> ContractTypes { get; set; }

        public DbSet<Data.Entity.Issue> Issues { get; set; }

        public DbSet<Data.Entity.Make> Makes { get; set; }

        public DbSet<Data.Entity.Model> Models { get; set; }

        public DbSet<Data.Entity.User> Users { get; set; }

        public DbSet<Data.Entity.UserGroup> UserGroups { get; set; }
        
        public DbSet<Data.Entity.UserGroupStatus> UserGroupStatuses { get; set; }

        public DbSet<Data.Entity.UserUserGroup> UserUserGroups { get; set; }

        public DbSet<Data.Entity.Vehicle> Vehicles { get; set; }

        public DbSet<Data.Entity.VehicleMakeModel> VehicleMakeModels { get; set; }

        public DbSet<Data.Entity.VehicleStatus> VehicleStatuses { get; set; }

        
    }
}
