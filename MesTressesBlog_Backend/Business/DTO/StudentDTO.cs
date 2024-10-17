using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class StudentDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly Birthdate { get; set; }

        public ICollection<ClassroomDTO> Classrooms { get; set; } = new List<ClassroomDTO>();
        public ICollection<CompetenceDTO> Competences { get; set; } = new List<CompetenceDTO>();
        public ICollection<StudentClassroomDTO> StudentClassrooms { get; set; } = new List<StudentClassroomDTO>(); 

    }
}
