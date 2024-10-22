using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ArticleSimpleTranslationDTO
    {
        // Base
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        // Article
        public int Id { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Status { get; set; } = string.Empty;  // published, draft, deleted
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public int UserName { get; set; }
        public string Domain { get; set; } = string.Empty; // (Math, )
        public string Level { get; set; } = string.Empty; // (Cycle 1, 2 ou 3)
        public string Category { get; set; } = string.Empty; // (Calcul, énumération ...)

        // Traduction
        public int IdTranslation { get; set; }
        public string TitleTranslation { get; set; } = string.Empty;
        public string ContentTranslation { get; set; } = string.Empty;
        public string ShortContentTranslation { get; set; } = string.Empty;
        public int? ArticleId { get; set; }
        public int? LanguageCode { get; set; }
    }
}
