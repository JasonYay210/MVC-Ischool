using Microsoft.AspNetCore.Mvc;
namespace IschoolJason.Models
{
    public class DegreesModel
    {
        public string pageTitle { get; set; }

        public UndergraduateDegree[] Undergraduate { get; set; }
        public GraduateDegree[] Graduate { get; set; }

        public class UndergraduateDegree
        {
            public string DegreeName { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string[] Concentrations { get; set; }
        }

        public class GraduateDegree
        {
            public string DegreeName { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string[] Concentrations { get; set; }
            public string[] AvailableCertificates { get; set; }
        }
    }
}
