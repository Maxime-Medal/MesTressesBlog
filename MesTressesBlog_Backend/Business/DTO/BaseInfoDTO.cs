using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BaseInfoDTO
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        [Column("CreatedBy")]
        public int? CreatedByUserId { get; set; }
        [Column("ModifiedBy")]
        public int? ModifiedByUserId { get; set; }
    }
}
