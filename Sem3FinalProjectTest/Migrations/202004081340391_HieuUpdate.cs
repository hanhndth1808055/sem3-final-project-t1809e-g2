namespace Sem3FinalProjectTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HieuUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hieux",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hieux");
        }
    }
}
