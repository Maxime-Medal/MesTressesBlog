﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Domain
    {
        public BaseInfo BaseInfo { get; set; } = new BaseInfo();

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; } = new List<Article>();
        public ICollection<DomainTranslation> DomainTranslations { get; set; } = new List<DomainTranslation>();
    }
}
