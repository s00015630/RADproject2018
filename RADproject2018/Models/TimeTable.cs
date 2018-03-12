using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TimeTable")]
public class TimeTable
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Timetable ID")]
    public int ID { get; set; }

    [Display(Name = "Name")]
    [Required()]
    public string Name { get; set; }

    [Display(Name = "Day")]
    [Required()]
    public DateTime Day { get; set; }

    [Display(Name = "Room")]
    [Required()]
    public string Room { get; set; }

    [Display(Name = "Start Time")]
    [Required()]
    public DateTime StartTime { get; set; }

    [Display(Name = "End Time")]
    [Required()]
    public DateTime EndTime { get; set; }

}

