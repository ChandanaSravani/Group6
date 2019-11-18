namespace Group6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoctorName = c.String(),
                        PhoneNumber = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                        City = c.String(),
                        Address = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        Specialisation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Doctors");
        }
    }
}
