using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class StudentClassroom
    {
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
        public int? ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }

        // Numéro d'élève spécifique à chaque classe
        public int StudentNumber { get; set; }

    }
}
