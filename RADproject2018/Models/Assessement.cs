using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Assessment")]
public class Assessement
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Assessment ID")]
    public int ID { get; set; }

    [Display(Name = "Course ID")]
    [ForeignKey("ID")]
    [Required()]
    public Course CourseID { get; set; }

    [Display(Name = "Instructor ID")]
    [ForeignKey("ID")]
    [Required()]
    public Instructor InstructorID { get; set; }

    [Display(Name = "Description")]
    [Required()]
    public string Descrption { get; set; }

}

