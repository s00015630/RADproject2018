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

        [Display(Name = "Name")]
        [Required()]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required()]
        public string Description { get; set; }

        [Display(Name = "Type")]
        [Required()]
        public string Type { get; set; }

        [Display(Name = "Term")]
        [Required()]
        public string Term { get; set; }

    }

}