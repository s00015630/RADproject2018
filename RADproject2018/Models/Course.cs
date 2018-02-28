using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Course")]
public class Course
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    [Required()]
    public int ID;
    [Display(Name = "Name")]
    [Required()]
    public string Name;
    [Display(Name = "Description")]
    [Required()]
    public string Describion;
    [Display(Name = "Type")]
    [Required()]
    public string Type;
    [Display(Name = "Term")]
    [Required()]
    public string Term;

}

