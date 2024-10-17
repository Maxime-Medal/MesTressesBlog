using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class LevelTranslationDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int? LevelId { get; set; }
        public LevelDTO? Level { get; set; }
        public int? LanguageId { get; set; }
        public LanguageDTO? Language { get; set; }
    }
}
