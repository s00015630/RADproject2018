namespace RADproject2018.Migrations.StudentCourses
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assessment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        InstructorID = c.Int(nullable: false),
                        Descrption = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Course", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Instructor", t => t.InstructorID, cascadeDelete: true)
                .Index(t => t.CourseID)
                .Index(t => t.InstructorID);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        Term = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Instructor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InstructorNum = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Rank = c.String(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        SectionID = c.Int(nullable: false),
                        DateAttended = c.DateTime(nullable: false),
                        Hours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Section", t => t.SectionID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.SectionID);
            
            CreateTable(
                "dbo.Section",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseID_ID = c.Int(nullable: false),
                        InstrurctorID_ID = c.Int(nullable: false),
                        TimeTableID_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Course", t => t.CourseID_ID, cascadeDelete: true)
                .ForeignKey("dbo.Instructor", t => t.InstrurctorID_ID, cascadeDelete: true)
                .ForeignKey("dbo.TimeTable", t => t.TimeTableID_ID, cascadeDelete: true)
                .Index(t => t.CourseID_ID)
                .Index(t => t.InstrurctorID_ID)
                .Index(t => t.TimeTableID_ID);
            
            CreateTable(
                "dbo.TimeTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Day = c.DateTime(nullable: false),
                        Room = c.String(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        StudentNum = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AcadmaicYear = c.Int(nullable: false),
                        Term = c.Int(nullable: false),
                        DateEnrolled = c.DateTime(nullable: false),
                        StudentID = c.Int(nullable: false),
                        SectionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Section", t => t.SectionID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.SectionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollment", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Enrollment", "SectionID", "dbo.Section");
            DropForeignKey("dbo.Attendance", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Attendance", "SectionID", "dbo.Section");
            DropForeignKey("dbo.Section", "TimeTableID_ID", "dbo.TimeTable");
            DropForeignKey("dbo.Section", "InstrurctorID_ID", "dbo.Instructor");
            DropForeignKey("dbo.Section", "CourseID_ID", "dbo.Course");
            DropForeignKey("dbo.Assessment", "InstructorID", "dbo.Instructor");
            DropForeignKey("dbo.Assessment", "CourseID", "dbo.Course");
            DropIndex("dbo.Enrollment", new[] { "SectionID" });
            DropIndex("dbo.Enrollment", new[] { "StudentID" });
            DropIndex("dbo.Section", new[] { "TimeTableID_ID" });
            DropIndex("dbo.Section", new[] { "InstrurctorID_ID" });
            DropIndex("dbo.Section", new[] { "CourseID_ID" });
            DropIndex("dbo.Attendance", new[] { "SectionID" });
            DropIndex("dbo.Attendance", new[] { "StudentID" });
            DropIndex("dbo.Assessment", new[] { "InstructorID" });
            DropIndex("dbo.Assessment", new[] { "CourseID" });
            DropTable("dbo.Enrollment");
            DropTable("dbo.Student");
            DropTable("dbo.TimeTable");
            DropTable("dbo.Section");
            DropTable("dbo.Attendance");
            DropTable("dbo.Instructor");
            DropTable("dbo.Course");
            DropTable("dbo.Assessment");
        }
    }
}
