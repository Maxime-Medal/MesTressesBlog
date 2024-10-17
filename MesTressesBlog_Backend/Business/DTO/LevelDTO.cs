﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class LevelDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Article> Articles { get; set; } = new List<Article>();
        public ICollection<LevelTranslationDTO> LevelTranslations { get; set; } = new List<LevelTranslationDTO>();
        public ICollection<CompetenceDTO> Competences { get; set; } = new List<CompetenceDTO>();
       
    }
}
