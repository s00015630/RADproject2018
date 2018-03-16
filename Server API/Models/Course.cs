using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server_API.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Course ID")]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Enrollment> Enrollements { get; set; }
        public virtual ICollection<DeliveryOfCourse> Deliveries { get; set; }

    }

}