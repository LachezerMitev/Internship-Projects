using AutoServiceShop.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao
{
    public class AutoServiceShopContext : DbContext
    {
        public AutoServiceShopContext() : base("AutoServiceShopDB")
        {
            
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data.Entity.Account>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Accounts");
            });

            modelBuilder.Entity<Data.Entity.AccountStatus>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("AccountStatuses");
            });

            modelBuilder.Entity<Data.Entity.AccountType>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("AccountTypes");
            });

            modelBuilder.Entity<Data.Entity.AutoPart>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("AutoParts");
            });

            modelBuilder.Entity<Data.Entity.AutoPartStatus>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("AutoPartStatuses");
            });

            modelBuilder.Entity<Data.Entity.CheckUp>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("CheckUps");
            });

            modelBuilder.Entity<Data.Entity.CheckUpStatus>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("CheckUpStatuses");
            });

            modelBuilder.Entity<Data.Entity.Contract>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Contracts");
            });

            modelBuilder.Entity<Data.Entity.ContractStatus>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ContractStatuses");
            });

            modelBuilder.Entity<Data.Entity.ContractType>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ContractTypes");
            });

            modelBuilder.Entity<Data.Entity.Issue>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Issues");
            });

            modelBuilder.Entity<Data.Entity.Make>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Makes");
            });

            modelBuilder.Entity<Data.Entity.Model>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Models");
            });

            modelBuilder.Entity<Data.Entity.User>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Users");
            });

            modelBuilder.Entity<Data.Entity.UserGroup>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("UserGroups");
            });

            modelBuilder.Entity<Data.Entity.UserGroupStatus>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("UserGroupStatuses");
            });

            modelBuilder.Entity<Data.Entity.UserUserGroup>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("UserUserGroups");
            });

            modelBuilder.Entity<Data.Entity.Vehicle>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Vehicles");
            });

            modelBuilder.Entity<Data.Entity.VehicleMakeModel>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("VehicleMakeModels");
            });

            modelBuilder.Entity<Data.Entity.VehicleStatus>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("VehicleStatuses");
            });
        }
    }
}
