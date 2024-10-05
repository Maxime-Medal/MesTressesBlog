using Data.Models;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class ArticleService
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<Article> GetArticleByIdWithTranslationAsync(int id, string languageCOde)
        {
            return await _articleRepository.GetArticleByIdWithTranslationAsync(id, languageCOde);
        }
    }
}
