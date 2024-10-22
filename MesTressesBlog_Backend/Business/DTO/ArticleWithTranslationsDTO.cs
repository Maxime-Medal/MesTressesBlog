using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ArticleWithTranslationsDTO
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
        public DomainDTO? Domain { get; set; } // (Math, )
        public LevelDTO? Level { get; set; } // (Cycle 1, 2 ou 3)
        public CategoryDTO? Category { get; set; } // (Calcul, énumération ...)
        
        // Traductions
        public int IdTranslation { get; set; }
        public string TitleTranslation { get; set; } = string.Empty;
        public string ContentTranslation { get; set; } = string.Empty;
        public string ShortContentTranslation { get; set; } = string.Empty;


        public ICollection<ArticleTranslationDTO> Translations { get; set; } = new List<ArticleTranslationDTO>();
        public ICollection<DocumentDTO> Documents { get; set; } = new List<DocumentDTO>();
        public ICollection<CommentDTO> Comments { get; set; } = new List<CommentDTO>();
    }
}
