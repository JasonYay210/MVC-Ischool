using Microsoft.AspNetCore.Mvc;

namespace IschoolJason.Models
{
    public class MinorsModel
    {
        public string pageTitle { get; set; }
        public List<Minor> UgMinors { get; set; }
        public List<Course> Courses { get; set; }

    }

    public class Minor
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<String> Courses { get; set; } 
        public string Note { get; set; }
    }


    public class Course
    {
        public string courseID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

}
