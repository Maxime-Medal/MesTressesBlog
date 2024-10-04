using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }

        public int? StudentId { get; set; }
        public Student? Student { get; set; }

        public ICollection<Competence> Competences { get; set; } = new List<Competence>();
    }
}
