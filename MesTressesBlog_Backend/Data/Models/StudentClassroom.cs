using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly Birthdate { get; set; }
        public IList<int> StudentNumber { get; set; } = new List<int>(); // numéro de l'élève de la classe x

        public ICollection<Classroom> Classrooms { get; set; } = new List<Classroom>();
        public ICollection<Grade> Grades { get; set; }=new List<Grade>();
        public ICollection<Competence> Competences { get; set; } = new List<Competence>();

    }
}
