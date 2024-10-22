using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CommentDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime TimeStamp { get; set; }

        public int? ArticleId { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}
