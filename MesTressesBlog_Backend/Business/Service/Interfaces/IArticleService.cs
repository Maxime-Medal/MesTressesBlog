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
        Task<ArticleDTO> GetFullArticleByIdAsync(int id);
        Task<Article> GetArticleByIdWithTranslationAsync(int id, string languageCode);
        Task<IEnumerable<Article>> GetAllArticlesAsync();
        Task<int> AddArticleAsync();
        Task<Article> UpdateArticleAsync();
        Task<bool> DeleteArticleAsync(int id);

    }
}
