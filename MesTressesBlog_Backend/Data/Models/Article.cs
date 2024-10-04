using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Article : Base
    {
        public int Id { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Status { get; set; } // published, draft, deleted
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; } = null!;
        public int? DomainId { get; set; } // (Math, )
        public Domain? Domain { get; set; }
        public int? LevelId { get; set; } // (Cycle 1, 2 ou 3)
        public Level? Level { get; set; }
        public int? CategoryId { get; set; } // (Calcul, énumération ...)
        public Category? Category { get; set; }

        public ICollection<ArticleTranslation> Translations { get; set; } = new List<ArticleTranslation>();
        public ICollection<Document> Documents { get; set; } = new List<Document>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
