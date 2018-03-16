namespace Server_API.Migrations.AttendanceMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentAttendances",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        attended = c.Boolean(nullable: false),
                        AttendanceOf_ID = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Attendance", t => t.AttendanceOf_ID)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.AttendanceOf_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAttendances", "StudentID", "dbo.Student");
            DropForeignKey("dbo.StudentAttendances", "AttendanceOf_ID", "dbo.Attendance");
            DropIndex("dbo.StudentAttendances", new[] { "AttendanceOf_ID" });
            DropIndex("dbo.StudentAttendances", new[] { "StudentID" });
            DropTable("dbo.StudentAttendances");
        }
    }
}
