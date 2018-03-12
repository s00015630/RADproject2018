using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Score")]
public class Score
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Score ID")]
    public int ID { get; set; }


    [ForeignKey("AssoassociatedEnrollment")]
    [Required()]
    public int EnrollmentID { get; set; }


    [ForeignKey("AssoassociatedAssessment")]
    [Required()]
    public int AssessementID { get; set; }

    [Display(Name = "Grade")]
    [Required()]
    public int Grade { get; set; }

    
    [ForeignKey("AssoassociatedStudent")]
    [Required()]
    public int StudentID { get; set; }

    public virtual Assessement AssoassociatedAssessment { get; set; }
    public virtual Student AssoassociatedStudent { get; set; }
    public virtual Enrollment AssoassociatedEnrollment { get; set; }

}

