using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Instructor")]
public class Instructor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    public int ID;

    [Display(Name = "Instructor Name")]
    public int InstructorNum;

    [Display(Name = "First Name")]
    public string FirstName;

    [Display(Name = "Last Name")]
    public string LastName;

    [Display(Name = "Rank")]
    public string Rank;

    [Display(Name = "Tyoe")]
    public string Type;

}

