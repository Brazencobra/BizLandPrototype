using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BizLand.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(50),MinLength(3),Required(ErrorMessage = "Ad boş buraxıla bilməz")]
        public string Name { get; set; }
        [MaxLength(50),MinLength(4)]
        public string? Surname { get; set; }
        public string? Position { get; set; }
        public string? ImageUrl { get; set; }
    }
}
