using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Level
    {
        public BaseInfo BaseInfo { get; set; } = new BaseInfo();

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; } = new List<Article>();
        public ICollection<LevelTranslation> LevelTranslations { get; set; } = new List<LevelTranslation>();
        public ICollection<Competence> Competences { get; set; } = new List<Competence>();
       
    }
}
