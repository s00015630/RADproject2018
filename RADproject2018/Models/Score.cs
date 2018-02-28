using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Score")]
public class Score
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID;
    [ForeignKey("Enrollment")]
    public Enrollment EnrollmentID;
    [ForeignKey("Assessement")]
    public Assessement AssessementID;
	public int Grade;
    [ForeignKey("Student")]
    public Student StudentID;

}

