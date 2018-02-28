using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Attendance")]
public class Attendance
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    public int ID;

    [Display(Name = "Student ID")]
    [ForeignKey("ID")]
    public Student StudentID;

    [Display(Name = "Section ID")]
    [ForeignKey("ID")]
    public Section SectionID;

    [Display(Name = "Date Attended")]
    public DateTime DateAttended;

    [Display(Name = "Hours")]
    public int Hours;

}

