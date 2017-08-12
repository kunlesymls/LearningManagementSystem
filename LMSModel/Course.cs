using System.Collections.Generic;

namespace LMSModel
{
    public class Course
    {
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int ExpectedTime { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
    }
}
