using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace Server_API.Models
{
    [Table("Enrollment")]
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Enrollment ID")]
        public int ID { get; set; }

        public int AcadmaicYear { get; set; }

        [Display(Name = "Date Enrolled")]
        public DateTime DateEnrolled { get; set; }


        [ForeignKey("EnrolledStudent")]
        public int StudentID { get; set; }


        [ForeignKey("EnrolledCourse")]
        public int CourseID { get; set; }


        public virtual Student EnrolledStudent { get; set; }
        public virtual Course EnrolledCourse { get; set; }



    }

}