using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GraduateProject.Models
{
    public class Profile
    {
        public string? Name { get; set; }

        [DisplayName("Last Name")]
        public string? Surname { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime Date_Of_Birth { get; set; }

        public int Age { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }

        public int Id { get; set; }
    }
}
