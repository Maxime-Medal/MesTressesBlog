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
        Task<Article> GetArticleByIdWithTranslationAsync(int id, string languageCode);
        Task<IEnumerable<Article>> GetAllArticlesAsync();
        Task AddArticleAsync(Article article);
        Task UpdateArticleAsync(Article article);
        Task DeleteArticleAsync(int id);
    }
}
