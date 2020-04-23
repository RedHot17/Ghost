using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ghost.Models
{
    public class Teacher
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }
        [StringLength(50)]
        public string Degree { get; set; }
        [StringLength(25)]
        [Display(Name = "Academic Rank")]
        public string AcademicRank { get; set; }
        [StringLength(10)]
        [Display(Name = "Office Number")]
        public string OfficeNumber { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }
        [NotMapped]
        public ICollection<Course> Courses1 { get; set; }
        public ICollection<Course> Courses2 { get; set; }
    }
}
