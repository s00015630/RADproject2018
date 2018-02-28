using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table(Name = "Assessment")]
public class Assessement
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    public int ID;

    [Display(Name = "Course ID")]
    [ForeignKey("ID")]
	public Course CourseID;

    [Display(Name = "Instructor ID")]
    [ForeignKey("ID")]
	public Instructor InstructorID;

    [Display(Name = "Description")]
    public string Descrption { get; set; }

}

