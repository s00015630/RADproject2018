using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Student")]
public class Student
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Student ID")]
    public int ID { get; set; }

    [Display(Name = "First Name")]
    [Required()]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required()]
    public string LastName { get; set; }

    [Display(Name = "Student Number")]
    [Required()]
    public string StudentNum { get; set; }

    [Display(Name = "Email")]
    [Required()]
    public string Email { get; set; }

}

