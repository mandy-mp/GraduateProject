using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace GraduateProject.Models
{
    public class ProfileViewModel
    {
        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? DOB { get; set; }

        public int Age { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }
    }
}
