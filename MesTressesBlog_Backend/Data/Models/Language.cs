using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Language
    {
        public BaseInfo BaseInfo { get; set; } = new BaseInfo();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<ArticleTranslation> ArticleTranslations { get; set; } = new List<ArticleTranslation>();
        public ICollection<DocumentTranslation> DocumentTranslations { get; set; } = new List<DocumentTranslation>();
        public ICollection<DomainTranslation> DomainTranslations { get; set; } = new List<DomainTranslation>();
        public ICollection<LevelTranslation> LevelTranslations { get; set; } = new List<LevelTranslation>();
        public ICollection<CategoryTranslation> CategoryTranslations { get; set; } = new List<CategoryTranslation>();
        public ICollection<User> Users { get; set; } = new List<User>();

    }
}
 