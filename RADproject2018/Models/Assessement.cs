using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Assessement
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID;

	public Course CourseID;

	public Instructor InstructorID;

    public string Descrption { get; set; }

}

