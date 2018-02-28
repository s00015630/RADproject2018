using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table(Name = "Enrollment")]
public class Enrollment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    [Required()]
    public int ID;

    [Display(Name = "Acadamic Year")]
    [Required()]
    public int AcadmaicYear;

    [Display(Name = "Term")]
    [Required()]
    public int Term;

    [Display(Name = "Date Enrolled")]
    [Required()]
    public DateTime DateEnrolled;

    [Display(Name = "Student ID")]
    [ForeignKey("ID")]
    [Required()]
    public Student StudentID;

    [Display(Name = "Section ID")]
    [ForeignKey("ID")]
    [Required()]
    public Section SectionID;

}

