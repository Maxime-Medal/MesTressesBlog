using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ArticleTranslation : Base
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ShortContent { get; set; }

        public int? ArticleId { get; set; }
        public Article? Article { get; set; }
        public int? LanguageId { get; set; }
        public Language? Language { get; set; }
    }
}
