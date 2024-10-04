using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Competence
    {
        public BaseInfo BaseInfo { get; set; } = new BaseInfo();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AssessmentDate { get; set; }

        public int? DomainId { get; set; }
        public Domain? Domain { get; set; }
        public int? LevelId { get; set; }
        public Level? Level { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
