using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Score
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID;

	public Enrollment EnrollmentID;

	public Assessement AssessementID;

	public int Grade;

	public Student StudentID;

}

