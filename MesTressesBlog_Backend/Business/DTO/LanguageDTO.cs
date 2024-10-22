using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class LanguageDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;

        public ICollection<ArticleTranslationDTO> ArticleTranslations { get; set; } = new List<ArticleTranslationDTO>();
        public ICollection<DocumentTranslationDTO> DocumentTranslations { get; set; } = new List<DocumentTranslationDTO>();
        public ICollection<DomainTranslationDTO> DomainTranslations { get; set; } = new List<DomainTranslationDTO>();
        public ICollection<LevelTranslationDTO> LevelTranslations { get; set; } = new List<LevelTranslationDTO>();
        public ICollection<CategoryTranslation> CategoryTranslations { get; set; } = new List<CategoryTranslation>();
        public ICollection<UserDTO> Users { get; set; } = new List<UserDTO>();

    }
}
 