using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TimeTable")]
public class TimeTable
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    [Required()]
    public int ID;

    [Display(Name = "Name")]
    [Required()]
    public string Name;

    [Display(Name = "Day")]
    [Required()]
    public DateTime Day;

    [Display(Name = "Room")]
    [Required()]
    public string Room;

    [Display(Name = "Start Time")]
    [Required()]
    public DateTime StartTime;

    [Display(Name = "End Time")]
    [Required()]
    public DateTime EndTime;

}

