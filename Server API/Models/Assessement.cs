using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server_API.Models
{
    [Table("Assessment")]
    public class Assessement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Assessment ID")]
        public int ID { get; set; }


        [ForeignKey("AssociatedCourse")]
        public int CourseID { get; set; }

        [ForeignKey("AssociatedInstructor")]
        public int InstructorID { get; set; }

        public string Descrption { get; set; }

        public virtual Course AssociatedCourse { get; set; }
        public virtual Instructor AssociatedInstructor { get; set; }

    }

}