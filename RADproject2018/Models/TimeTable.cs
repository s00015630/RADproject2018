using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TimeTable
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID;

	public string Name;

	public DateTime Day;

	public string Room;

	public DateTime StartTime;

	public DateTime EndTime;

}

