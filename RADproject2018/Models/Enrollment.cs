using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Enrollment")]
public class Enrollment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    public int ID;

    [Display(Name = "Acadamic Year")]
    public int AcadmaicYear;

    [Display(Name = "Term")]
    public int Term;

    [Display(Name = "Date Enrolled")]
    public DateTime DateEnrolled;

    [Display(Name = "Student ID")]
    [ForeignKey("ID")]
    public Student StudentID;

    [Display(Name = "Section ID")]
    [ForeignKey("ID")]
    public Section SectionID;

}

