using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Score")]
public class Section
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Section ID")]
    public int ID { get; set; }

    [Display(Name = "Course ID")]
    [Required()]
    public Course CourseID { get; set; }

    [Display(Name = "Instructor ID")]
    [Required()]
    public Instructor InstrurctorID { get; set; }

    [Display(Name = "Time Table ID")]
    [Required()]
    public TimeTable TimeTableID { get; set; }

}

