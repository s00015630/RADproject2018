namespace Server_API.Migrations.AttendanceMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialAttendanceMigration : DbMigration
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
                        Descrption = c.String(),
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
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DeliveryOfCourse",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InstrurctorID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        DayDelivered = c.String(),
                        TimeTableID_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Instructor", t => t.InstrurctorID, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.TimeTable", t => t.TimeTableID_ID)
                .Index(t => t.InstrurctorID)
                .Index(t => t.CourseID)
                .Index(t => t.TimeTableID_ID);
            
            CreateTable(
                "dbo.Instructor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InstructorNum = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TimeTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Day = c.DateTime(nullable: false),
                        Room = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AcadmaicYear = c.Int(nullable: false),
                        DateEnrolled = c.DateTime(nullable: false),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Course", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StudentNum = c.String(),
                        Email = c.String(),
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
                .ForeignKey("dbo.DeliveryOfCourse", t => t.SectionID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.SectionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendance", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Attendance", "SectionID", "dbo.DeliveryOfCourse");
            DropForeignKey("dbo.Assessment", "InstructorID", "dbo.Instructor");
            DropForeignKey("dbo.Assessment", "CourseID", "dbo.Course");
            DropForeignKey("dbo.Enrollment", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Enrollment", "CourseID", "dbo.Course");
            DropForeignKey("dbo.DeliveryOfCourse", "TimeTableID_ID", "dbo.TimeTable");
            DropForeignKey("dbo.DeliveryOfCourse", "CourseID", "dbo.Course");
            DropForeignKey("dbo.DeliveryOfCourse", "InstrurctorID", "dbo.Instructor");
            DropIndex("dbo.Attendance", new[] { "SectionID" });
            DropIndex("dbo.Attendance", new[] { "StudentID" });
            DropIndex("dbo.Enrollment", new[] { "CourseID" });
            DropIndex("dbo.Enrollment", new[] { "StudentID" });
            DropIndex("dbo.DeliveryOfCourse", new[] { "TimeTableID_ID" });
            DropIndex("dbo.DeliveryOfCourse", new[] { "CourseID" });
            DropIndex("dbo.DeliveryOfCourse", new[] { "InstrurctorID" });
            DropIndex("dbo.Assessment", new[] { "InstructorID" });
            DropIndex("dbo.Assessment", new[] { "CourseID" });
            DropTable("dbo.Attendance");
            DropTable("dbo.Student");
            DropTable("dbo.Enrollment");
            DropTable("dbo.TimeTable");
            DropTable("dbo.Instructor");
            DropTable("dbo.DeliveryOfCourse");
            DropTable("dbo.Course");
            DropTable("dbo.Assessment");
        }
    }
}
