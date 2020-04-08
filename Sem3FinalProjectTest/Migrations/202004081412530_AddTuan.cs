namespace Sem3FinalProjectTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTuan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tuans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tuans");
        }
    }
}
