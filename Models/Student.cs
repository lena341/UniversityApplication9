using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FirstMidName { get; set; }

        [Display(Name = "Student ID")]
        [Required]
        public int StudentIdent { get; set; }

        [Display(Name = "Semester")]
        [Required]
        public int Semester { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<Direction> Directions { get; set; }
    }
}
