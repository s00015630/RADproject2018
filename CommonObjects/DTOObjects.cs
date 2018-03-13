using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonObjects
{
    public class AssessementDTO
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int InstructorID { get; set; }
        public string Descrption { get; set; }

        public CourseDTO Course { get; set; }
        public InstructorDTO Instructor { get; set; }
    }

    public class AttendanceDTO
    {
        public int ID { get; set; }    
        public int StudentID { get; set; }      
        public int SectionID { get; set; }   
        public DateTime DateAttended { get; set; }
        public int Hours { get; set; }
        public StudentDTO Student { get; set; }
        public SectionDTO Section { get; set; }
    }

    public class CourseDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Term { get; set; }
    }

    public class EnrollmentDTO
    {
      
        public int ID { get; set; }
        public int AcadmaicYear { get; set; }
        public int Term { get; set; }
        public DateTime DateEnrolled { get; set; }
        public int StudentID { get; set; }
        public int SectionID { get; set; }

        public StudentDTO Student { get; set; }
        public SectionDTO Section { get; set; }

    }

    public class InstructorDTO
    {
        public int ID { get; set; }
        public int InstructorNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Rank { get; set; }
        public string Type { get; set; }

    }

    public class ScoreDTO
    {
        public int ID { get; set; }
        public int AssessementID { get; set; }
        public int Grade { get; set; }
        public int StudentID { get; set; }

        public AssessementDTO Assessment { get; set; }
        public StudentDTO Student { get; set; }
        
    }

    public class SectionDTO
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int InstrurctorID { get; set; }
        public int TimeTableID { get; set; }

    }

    public class StudentDTO
    {
       
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNum { get; set; }
        public string Email { get; set; }

    }

    public class TimeTableDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Day { get; set; }
        public string Room { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }




}
