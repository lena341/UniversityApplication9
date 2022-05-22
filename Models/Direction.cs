using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Direction
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Direction Name")]
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string DirectionName { get; set; }

        [Display(Name = "Student ID")]
        [Required]
        public int StudentIdent { get; set; }

        public Student Student { get; set; }
    }
}
