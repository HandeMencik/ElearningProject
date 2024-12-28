namespace MyElearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_relation_instructor_course : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "InstructorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "InstructorId");
            AddForeignKey("dbo.Courses", "InstructorId", "dbo.Instructors", "InstructorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "InstructorId", "dbo.Instructors");
            DropIndex("dbo.Courses", new[] { "InstructorId" });
            DropColumn("dbo.Courses", "InstructorId");
        }
    }
}
