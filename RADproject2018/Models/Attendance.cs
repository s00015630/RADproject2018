using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Attendance")]
public class Attendance
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    [Required()]
    public int ID;

    [Display(Name = "Student ID")]
    [ForeignKey("ID")]
    [Required()]
    public Student StudentID;

    [Display(Name = "Section ID")]
    [ForeignKey("ID")]
    [Required()]
    public Section SectionID;

    [Display(Name = "Date Attended")]
    [Required()]
    public DateTime DateAttended;

    [Display(Name = "Hours")]
    [Required()]
    public int Hours;

}

