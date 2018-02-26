using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Instructor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID;

	public int InstructorNum;

	public string FirstName;

	public string LastName;

	public string Rank;

	public string Type;

}

