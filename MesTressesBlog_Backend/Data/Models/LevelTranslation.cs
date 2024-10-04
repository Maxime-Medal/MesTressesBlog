using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class LevelTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? LevelId { get; set; }
        public Level? Level { get; set; }
        public int? LanguageId { get; set; }
        public Language? Language { get; set; }
    }
}
