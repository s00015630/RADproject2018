using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Attendance")]
public class Attendance
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Attendance ID")]
    public int ID { get; set; }

    [Display(Name = "Student ID")]
    [ForeignKey("ID")]
    [Required()]
    public Student StudentID { get; set; }

    [Display(Name = "Section ID")]
    [ForeignKey("ID")]
    [Required()]
    public Section SectionID { get; set; }

    [Display(Name = "Date Attended")]
    [Required()]
    public DateTime DateAttended { get; set; }

    [Display(Name = "Hours")]
    [Required()]
    public int Hours { get; set; }

}

