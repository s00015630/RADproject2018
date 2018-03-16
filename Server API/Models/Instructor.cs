using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server_API.Models
{
    [Table("Instructor")]
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Instructor ID")]
        public int ID { get; set; }

        [Display(Name = "Instructor Name")]
        public int InstructorNum { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public virtual ICollection<DeliveryOfCourse> DeliveryInstructor { get; set; }

    }
}
