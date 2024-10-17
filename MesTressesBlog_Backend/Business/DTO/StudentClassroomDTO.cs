using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class StudentClassroomDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int? StudentId { get; set; }
        public StudentDTO? Student { get; set; }
        public int? ClassroomId { get; set; }
        public ClassroomDTO? Classroom { get; set; }

        // Numéro d'élève spécifique à chaque classe
        public int StudentNumber { get; set; }

    }
}
