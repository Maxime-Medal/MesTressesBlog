using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Student
    {
        public BaseInfo BaseInfo { get; set; } = new BaseInfo();

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly Birthdate { get; set; }

        public ICollection<Classroom> Classrooms { get; set; } = new List<Classroom>();
        public ICollection<Competence> Competences { get; set; } = new List<Competence>();
        public ICollection<StudentClassroom> StudentClassrooms { get; set; } = new List<StudentClassroom>(); 

    }
}
