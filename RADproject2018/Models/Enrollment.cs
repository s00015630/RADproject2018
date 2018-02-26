using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Enrollment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID;

	public int AcadmaicYear;

	public int Term;

	public DateTime DateEnrolled;

	public Student StudentID;

	public Section SectionID;

}

