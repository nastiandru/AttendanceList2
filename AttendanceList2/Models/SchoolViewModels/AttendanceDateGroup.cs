using System;
using System.ComponentModel.DataAnnotations;

namespace AttendanceList2.Models.SchoolViewModels
{
    public class AttendanceDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? AttendanceDate { get; set; }

        public int StudentCount { get; set; }
    }
}
