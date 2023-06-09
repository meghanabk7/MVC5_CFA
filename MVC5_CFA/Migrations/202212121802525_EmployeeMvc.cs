﻿namespace MVC5_CFA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeMvc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DOJ = c.DateTime(nullable: false),
                        designation = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
