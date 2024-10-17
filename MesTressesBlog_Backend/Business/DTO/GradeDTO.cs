using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class GradeDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public string Value { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        public int? StudentId { get; set; }
        public StudentDTO? Student { get; set; }

        public ICollection<CompetenceDTO> Competences { get; set; } = new List<CompetenceDTO>();
    }
}
