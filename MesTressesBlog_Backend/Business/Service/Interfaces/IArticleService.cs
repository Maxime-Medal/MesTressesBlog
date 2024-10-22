using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service.Interfaces
{
    public interface IArticleService
    {
        Task<ArticleWithTranslationsDTO> GetArticleByIdAsync(int id);
        Task<ArticleWithTranslationsDTO> GetArticleByIdWithTranslationAsync(int id, string languageCode);
        Task<IEnumerable<ArticleWithTranslationsDTO>> GetAllArticlesAsync();
        Task<int> AddArticleAsync();
        Task<ArticleWithTranslationsDTO> UpdateArticleAsync();
        Task<bool> DeleteArticleAsync(int id);

    }
}
