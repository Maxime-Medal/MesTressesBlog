using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ClassroomDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SchoolYear { get; set; } = string.Empty;

        public ICollection<StudentDTO> Students { get; set; } = new List<StudentDTO>();
        public ICollection<StudentClassroomDTO> StudentClassrooms { get; set; } = new List<StudentClassroomDTO>();
    }
}
