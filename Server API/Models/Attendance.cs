using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server_API.Models
{
    [Table("Attendance")]
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Attendance ID")]
        public int ID { get; set; }


        [ForeignKey("AssociatedStudent")]
        [Required()]
        public int StudentID { get; set; }


        [ForeignKey("AssociatedSection")]
        [Required()]
        public int SectionID { get; set; }

        [Display(Name = "Date Attended")]
        [Required()]
        public DateTime DateAttended { get; set; }

        [Display(Name = "Hours")]
        [Required()]
        public int Hours { get; set; }

        public virtual Student AssociatedStudent { get; set; }

        public virtual Section AssociatedSection { get; set; }


    }
}

