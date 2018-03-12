using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Assessment")]
public class Assessement
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Assessment ID")]
    public int ID { get; set; }

    
    [ForeignKey("AssociatedCourse")]
    [Required()]
    public int CourseID { get; set; }

    
    [ForeignKey("AssociatedInstructor")]
    [Required()]
    public int InstructorID { get; set; }

    [Display(Name = "Description")]
    [Required()]
    public string Descrption { get; set; }

    public virtual Course AssociatedCourse { get; set; }
    public virtual Instructor AssociatedInstructor { get; set; }

}

