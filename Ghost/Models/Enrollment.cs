using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ghost.Models
{
    public class Enrollment
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string Semester { get; set; }
        public int Year { get; set; }
        public int Grade { get; set; }
        [StringLength(255)]
        [Display(Name = "Seminal URL")]
        public string SeminalUrl { get; set; }
        [StringLength(255)]
        [Display(Name = "Project URL")]
        public string ProjectUrl { get; set; }
        [Display(Name = "Exam Points")]
        public int ExamPoints { get; set; }
        [Display(Name = "Seminal Points")]
        public int SeminalPoints { get; set; }
        [Display(Name = "Project Points")]
        public int ProjectPoints { get; set; }
        [Display(Name = "Additional Points")]
        public int AdditionalPoints { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Finish Date")]
        public DateTime FinishDate { get; set; }
        [Required]
        public int? StudentId { get; set; }
        public Student Student { get; set; }
        [Required]
        public int? CourseId { get; set; }
        public Course Course { get; set; }
    }
}
