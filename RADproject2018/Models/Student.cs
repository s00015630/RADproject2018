using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Student")]
public class Student
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    [Required()]
    public int ID;

    [Display(Name = "First Name")]
    [Required()]
    public string FirstName;

    [Display(Name = "Last Name")]
    [Required()]
    public string LastName;

    [Display(Name = "Student Number")]
    [Required()]
    public string StudentNum;

    [Display(Name = "Email")]
    [Required()]
    public string Email;

}

