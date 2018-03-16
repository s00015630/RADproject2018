using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Server_API.Models
{
    public class StudentAttendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [ForeignKey("attendee")]
        public int StudentID { get; set; }
        public bool attended { get; set; }

        public virtual Student attendee { get; set; }
        public virtual Attendance AttendanceOf { get; set; }
    }
}