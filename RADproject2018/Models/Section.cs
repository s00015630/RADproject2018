using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Score")]
public class Section
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID;
	public Course CourseID;
	public Instructor InstrurctorID;
	public TimeTable TimeTableID;

}

