using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table(Name = "Course")]
public class Course
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    public int ID;

    [Display(Name = "Name")]
    public string Name;

    [Display(Name = "Description")]
    public string Describion;

    [Display(Name = "Type")]
    public string Type;

    [Display(Name = "Term")]
    public string Term;

}

