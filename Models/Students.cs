using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
        public string Password { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherRefId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
