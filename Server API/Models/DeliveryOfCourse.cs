using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server_API.Models
{
    [Table("DeliveryOfCourse")]
    public class DeliveryOfCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Delivery Of Course")]
        public int ID { get; set; }


        [ForeignKey("DeliveredBy")]
        public int InstrurctorID { get; set; }

        public TimeTable TimeTableID { get; set; }

        [ForeignKey("DeliveryOf")]
        public int CourseID { get; set; }
        public string DayDelivered { get; set; }

        public virtual Course DeliveryOf { get; set; }
        public virtual Instructor DeliveredBy { get; set; }

    }
}
