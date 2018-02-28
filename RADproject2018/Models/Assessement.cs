using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table(Name = "Assessment")]
public class Assessement
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    [Required()]
    public int ID;

    [Display(Name = "Course ID")]
    [ForeignKey("ID")]
    [Required()]
    public Course CourseID;

    [Display(Name = "Instructor ID")]
    [ForeignKey("ID")]
    [Required()]
    public Instructor InstructorID;

    [Display(Name = "Description")]
    [Required()]
    public string Descrption { get; set; }

}

