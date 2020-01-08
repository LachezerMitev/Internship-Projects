namespace AutoServiceShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutoServiceShopMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        FirstName = c.String(),
                        Surname = c.String(),
                        LastName = c.String(),
                        UserId = c.Long(nullable: false),
                        AccountStatusId = c.Long(nullable: false),
                        AccountTypeId = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountStatuses", t => t.AccountStatusId, cascadeDelete: true)
                .ForeignKey("dbo.AccountTypes", t => t.AccountTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.AccountStatusId)
                .Index(t => t.AccountTypeId);
            
            CreateTable(
                "dbo.AccountStatuses",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AutoParts",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        AutoPartStatusId = c.Long(nullable: false),
                        CheckUpId = c.Long(nullable: false),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AutoPartStatuses", t => t.AutoPartStatusId, cascadeDelete: true)
                .ForeignKey("dbo.CheckUps", t => t.CheckUpId, cascadeDelete: true)
                .Index(t => t.AutoPartStatusId)
                .Index(t => t.CheckUpId);
            
            CreateTable(
                "dbo.AutoPartStatuses",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CheckUps",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        CheckUpStatusId = c.Long(nullable: false),
                        Price = c.Double(nullable: false),
                        CheckUpStart = c.DateTime(nullable: false),
                        CheckUpEnd = c.DateTime(nullable: false),
                        VehicleId = c.Long(nullable: false),
                        CustomerId = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CheckUpStatuses", t => t.CheckUpStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.CheckUpStatusId)
                .Index(t => t.VehicleId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.CheckUpStatuses",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        VehicleStatusId = c.Long(nullable: false),
                        DateOfProduction = c.DateTime(nullable: false),
                        Mileage = c.Double(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VehicleStatuses", t => t.VehicleStatusId, cascadeDelete: true)
                .Index(t => t.VehicleStatusId);
            
            CreateTable(
                "dbo.VehicleStatuses",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        WorkDayStart = c.DateTime(nullable: false),
                        WorkDayEnd = c.DateTime(nullable: false),
                        Salary = c.Double(nullable: false),
                        ContractStatusId = c.Long(nullable: false),
                        ContractTypeId = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContractStatuses", t => t.ContractStatusId, cascadeDelete: true)
                .ForeignKey("dbo.ContractTypes", t => t.ContractTypeId, cascadeDelete: true)
                .Index(t => t.ContractStatusId)
                .Index(t => t.ContractTypeId);
            
            CreateTable(
                "dbo.ContractStatuses",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContractTypes",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        CheckUpId = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CheckUps", t => t.CheckUpId, cascadeDelete: true)
                .Index(t => t.CheckUpId);
            
            CreateTable(
                "dbo.Makes",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        UserGroupStatusId = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserGroupStatuses", t => t.UserGroupStatusId, cascadeDelete: true)
                .Index(t => t.UserGroupStatusId);
            
            CreateTable(
                "dbo.UserGroupStatuses",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserUserGroups",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        UserGroupId = c.Long(nullable: false),
                        UserId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.UserGroups", t => t.UserGroupId, cascadeDelete: true)
                .Index(t => t.UserGroupId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.VehicleMakeModels",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        VehicleId = c.Long(nullable: false),
                        MakeId = c.Long(nullable: false),
                        ModelId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Makes", t => t.MakeId, cascadeDelete: true)
                .ForeignKey("dbo.Models", t => t.ModelId, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.VehicleId)
                .Index(t => t.MakeId)
                .Index(t => t.ModelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehicleMakeModels", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.VehicleMakeModels", "ModelId", "dbo.Models");
            DropForeignKey("dbo.VehicleMakeModels", "MakeId", "dbo.Makes");
            DropForeignKey("dbo.UserUserGroups", "UserGroupId", "dbo.UserGroups");
            DropForeignKey("dbo.UserUserGroups", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserGroups", "UserGroupStatusId", "dbo.UserGroupStatuses");
            DropForeignKey("dbo.Issues", "CheckUpId", "dbo.CheckUps");
            DropForeignKey("dbo.Contracts", "ContractTypeId", "dbo.ContractTypes");
            DropForeignKey("dbo.Contracts", "ContractStatusId", "dbo.ContractStatuses");
            DropForeignKey("dbo.AutoParts", "CheckUpId", "dbo.CheckUps");
            DropForeignKey("dbo.CheckUps", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "VehicleStatusId", "dbo.VehicleStatuses");
            DropForeignKey("dbo.CheckUps", "CustomerId", "dbo.Accounts");
            DropForeignKey("dbo.CheckUps", "CheckUpStatusId", "dbo.CheckUpStatuses");
            DropForeignKey("dbo.AutoParts", "AutoPartStatusId", "dbo.AutoPartStatuses");
            DropForeignKey("dbo.Accounts", "UserId", "dbo.Users");
            DropForeignKey("dbo.Accounts", "AccountTypeId", "dbo.AccountTypes");
            DropForeignKey("dbo.Accounts", "AccountStatusId", "dbo.AccountStatuses");
            DropIndex("dbo.VehicleMakeModels", new[] { "ModelId" });
            DropIndex("dbo.VehicleMakeModels", new[] { "MakeId" });
            DropIndex("dbo.VehicleMakeModels", new[] { "VehicleId" });
            DropIndex("dbo.UserUserGroups", new[] { "UserId" });
            DropIndex("dbo.UserUserGroups", new[] { "UserGroupId" });
            DropIndex("dbo.UserGroups", new[] { "UserGroupStatusId" });
            DropIndex("dbo.Issues", new[] { "CheckUpId" });
            DropIndex("dbo.Contracts", new[] { "ContractTypeId" });
            DropIndex("dbo.Contracts", new[] { "ContractStatusId" });
            DropIndex("dbo.Vehicles", new[] { "VehicleStatusId" });
            DropIndex("dbo.CheckUps", new[] { "CustomerId" });
            DropIndex("dbo.CheckUps", new[] { "VehicleId" });
            DropIndex("dbo.CheckUps", new[] { "CheckUpStatusId" });
            DropIndex("dbo.AutoParts", new[] { "CheckUpId" });
            DropIndex("dbo.AutoParts", new[] { "AutoPartStatusId" });
            DropIndex("dbo.Accounts", new[] { "AccountTypeId" });
            DropIndex("dbo.Accounts", new[] { "AccountStatusId" });
            DropIndex("dbo.Accounts", new[] { "UserId" });
            DropTable("dbo.VehicleMakeModels");
            DropTable("dbo.UserUserGroups");
            DropTable("dbo.UserGroupStatuses");
            DropTable("dbo.UserGroups");
            DropTable("dbo.Models");
            DropTable("dbo.Makes");
            DropTable("dbo.Issues");
            DropTable("dbo.ContractTypes");
            DropTable("dbo.ContractStatuses");
            DropTable("dbo.Contracts");
            DropTable("dbo.VehicleStatuses");
            DropTable("dbo.Vehicles");
            DropTable("dbo.CheckUpStatuses");
            DropTable("dbo.CheckUps");
            DropTable("dbo.AutoPartStatuses");
            DropTable("dbo.AutoParts");
            DropTable("dbo.Users");
            DropTable("dbo.AccountTypes");
            DropTable("dbo.AccountStatuses");
            DropTable("dbo.Accounts");
        }
    }
}
