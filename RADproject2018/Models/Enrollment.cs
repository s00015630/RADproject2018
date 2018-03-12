using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Enrollment")]
public class Enrollment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Enrollment ID")]
    public int ID { get; set; }

    [Display(Name = "Acadamic Year")]
    [Required()]
    public int AcadmaicYear { get; set; }

    [Display(Name = "Term")]
    [Required()]
    public int Term { get; set; }

    [Display(Name = "Date Enrolled")]
    [Required()]
    public DateTime DateEnrolled { get; set; }

   
    [ForeignKey("AssociatedStudent")]
    [Required()]
    public int StudentID { get; set; }

    
    [ForeignKey("AssociatedSection")]
    [Required()]
    public int SectionID { get; set; }

    public virtual Student AssociatedStudent { get; set; }
    public virtual Section AssociatedSection { get; set; }

}

