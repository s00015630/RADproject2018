using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Score")]
public class Section
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    [Required()]
    public int ID;

    [Display(Name = "Course ID")]
    [Required()]
    public Course CourseID;

    [Display(Name = "Instructor ID")]
    [Required()]
    public Instructor InstrurctorID;

    [Display(Name = "Time Table ID")]
    [Required()]
    public TimeTable TimeTableID;

}

