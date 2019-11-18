namespace Group6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientName = c.String(),
                        TokenNo = c.String(),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
        }
    }
}
