using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IArticleRepository
    {
        Task<Article> GetArticleByIdAsync(int id);
        Task<Article> GetArticleByIdWithTranslationAsync(int id, string languageCode);
        Task<IEnumerable<Article>> GetAllArticlesAsync();
        Task<int> AddArticleAsync(Article article);
        Task<int> UpdateArticleAsync(Article article);
        Task<bool> DeleteArticleAsync(int id);
    }
}
