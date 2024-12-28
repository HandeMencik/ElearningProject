namespace MyElearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_about : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        Title = c.Int(nullable: false),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AboutId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
        }
    }
}
