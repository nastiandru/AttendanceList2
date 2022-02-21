using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AttendanceList2.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]

        public int CourseID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0, 5)]
        public int Credits { get; set; }

        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}
