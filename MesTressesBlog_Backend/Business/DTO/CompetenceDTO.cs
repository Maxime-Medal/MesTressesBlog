using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CompetenceDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime AssessmentDate { get; set; }

        public int? DomainId { get; set; }
        public DomainDTO? Domain { get; set; }
        public int? LevelId { get; set; }
        public LevelDTO? Level { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<StudentDTO> Students { get; set; } = new List<StudentDTO>();
        public ICollection<GradeDTO> Grades { get; set; } = new List<GradeDTO>();
    }
}
