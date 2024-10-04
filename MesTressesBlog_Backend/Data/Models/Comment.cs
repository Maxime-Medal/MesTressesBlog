using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Comment : Base
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

        public int? ArticleId { get; set; }
        public Article? Article { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
