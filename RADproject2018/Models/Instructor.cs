using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Instructor")]
public class Instructor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    [Required()]
    public int ID;

    [Display(Name = "Instructor Name")]
    [Required()]
    public int InstructorNum;

    [Display(Name = "First Name")]
    [Required()]
    public string FirstName;

    [Display(Name = "Last Name")]
    [Required()]
    public string LastName;

    [Display(Name = "Rank")]
    [Required()]
    public string Rank;

    [Display(Name = "Tyoe")]
    [Required()]
    public string Type;

}

