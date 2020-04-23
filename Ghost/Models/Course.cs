using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ghost.Models
{
    public class Course
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Title { get; set; }
        [Required]
        public int Credits { get; set; }
        [Required]
        public int Semester { get; set; }
        [StringLength(100)]
        public string Programme { get; set; }
        [StringLength(50)]
        [Display(Name = "Education Level")]
        public string EducationLevel { get; set; }
        [Display(Name ="First Teacher")]
        public int? FirstTeacherId { get; set; }
        [NotMapped]
        public Teacher TeacherOne { get; set; }
        [Display(Name = "Second Teacher")]
        public int? SecondTeacherId { get; set; }
        [NotMapped]
        public Teacher TeacherTwo { get; set; }
        public ICollection<Enrollment> Enrolls { get; set; }
    }
}
