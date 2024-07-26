using Microsoft.AspNetCore.Mvc;

namespace IschoolJason.Models
{
    public class CourseModel {
        public string pageTitle { get; set; }
        public List<Course> Courses { get; set; }

    }
}
