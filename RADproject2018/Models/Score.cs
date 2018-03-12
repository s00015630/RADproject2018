using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Score")]
public class Score
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Score ID")]
    public int ID { get; set; }

    [Display(Name = "Enrollment ID")]
    [ForeignKey("Enrollment")] 
    [Required()]
    public Enrollment EnrollmentID { get; set; }

    
    [ForeignKey("AssoassociatedAssessment")]
    [Required()]
    public int AssessementID { get; set; }

    [Display(Name = "Grade")]
    [Required()]
    public int Grade { get; set; }

    
    [ForeignKey("StudentID")]
    [Required()]
    public Student StudentID { get; set; }

    public virtual Assessement AssoassociatedAssessment { get; set; }

}

