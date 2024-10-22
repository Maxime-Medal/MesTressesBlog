using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class DocumentDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public string Type { get; set; } = string.Empty; // PDF, Audio, Video, Link
        public IList<string> FilePath { get; set; } = new List<string>(); // chemin d'accès vers minio
        public DateTime UploadDate { get; set; }

        public int? ArticleId { get; set; }
        public Article? Article { get; set; }
        public ICollection<DocumentTranslationDTO> DocumentTranslations { get; set; } = new List<DocumentTranslationDTO>();
    }
}
