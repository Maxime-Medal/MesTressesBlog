using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ArticleDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Status { get; set; } = string.Empty;  // published, draft, deleted
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

        public int? UserId { get; set; }
        public int? DomainId { get; set; } // (Math, )
        public int? LevelId { get; set; } // (Cycle 1, 2 ou 3)
        public int? CategoryId { get; set; } // (Calcul, énumération ...)

        public ICollection<ArticleTranslation> Translations { get; set; } = new List<ArticleTranslation>();
        public ICollection<DocumentDTO> Documents { get; set; } = new List<DocumentDTO>();
        public ICollection<CommentDTO> Comments { get; set; } = new List<CommentDTO>();
    }
}
