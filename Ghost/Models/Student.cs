using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ghost.Models
{
    public class Student
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        [Required]
        [Display(Name = "Student ID")]
        public string StudentId { get; set; }
        [StringLength(50)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }
        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Acquired Credits")]
        public int AcquiredCredits { get; set; }
        [Display(Name = "Current Semester")]
        public int CurrentSemester { get; set; }
        [StringLength(25)]
        [Display(Name = "Education Level")]
        public string EducationLevel { get; set; }
        public ICollection<Enrollment> Enrolls { get; set; }
    }
}
