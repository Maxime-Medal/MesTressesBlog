using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Classroom
    {
        public BaseInfo BaseInfo { get; set; } = new BaseInfo();

        public int Id { get; set; }
        public string Name { get; set; }
        public string SchoolYear{ get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<StudentClassroom> StudentClassrooms { get; set; } = new List<StudentClassroom>();
    }
}
