using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Instructor")]
public class Instructor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Instructor ID")]
    public int ID { get; set; }

    [Display(Name = "Instructor Name")]
    [Required()]
    public int InstructorNum { get; set; }

    [Display(Name = "First Name")]
    [Required()]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required()]
    public string LastName { get; set; }

    [Display(Name = "Rank")]
    [Required()]
    public string Rank { get; set; }

    [Display(Name = "Tyoe")]
    [Required()]
    public string Type { get; set; }

}

