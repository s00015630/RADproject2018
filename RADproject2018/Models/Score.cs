using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Score")]
public class Score
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    [Required()]
    public int ID;

    [Display(Name = "Enrollment ID")]
    [ForeignKey("Enrollment")] 
    [Required()]
    public Enrollment EnrollmentID;

    [Display(Name = "Assessment ID")]
    [ForeignKey("Assessement")]
    [Required()]
    public Assessement AssessementID;

    [Display(Name = "Grade")]
    [Required()]
    public int Grade;

    [Display(Name = "Student")]
    [ForeignKey("Student")]
    [Required()]
    public Student StudentID;

}

