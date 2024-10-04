using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Document : Base
    {
        public int Id { get; set; }
        public string Type { get; set; } // PDF, Audio, Video, Link
        public string FilePath { get; set; } // chemin d'accès vers minio
        public DateTime UploadDate { get; set; }

        public int? ArticleId { get; set; }
        public Article? Article { get; set; }
        public ICollection<DocumentTranslation> DocumentTranslations { get; set; } = new List<DocumentTranslation>();
    }
}
