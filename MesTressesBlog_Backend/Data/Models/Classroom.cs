using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SchoolYear{ get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
