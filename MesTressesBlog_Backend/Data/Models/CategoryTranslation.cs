﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CategoryTranslation
    {
        public BaseInfo BaseInfo { get; set; } = new BaseInfo();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public int? LanguageId { get; set; }
        public Language? Language { get; set; }
    }
}
