using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Course Name")]
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string CourseName { get; set; }

        [Display(Name = "Student ID")]
        [Required]
        public int StudentIdent { get; set; }

        public Student Student { get; set; }
    }
}
