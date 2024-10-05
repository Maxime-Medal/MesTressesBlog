using Data.Models;
using Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        public readonly MyDbContext _context;

        public ArticleRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task AddArticleAsync(Article article)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteArticleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Article>> GetAllArticlesAsync()
        {
            return await _context.Articles.ToListAsync();
        }

        public async Task<Article> GetArticleByIdWithTranslationAsync(int id, string languageCode)
        {
            return await _context.Articles
       .Where(a => a.Id == id)
       .Select(a => new Article
       {
           Id = a.Id,
           PublicationDate = a.PublicationDate,
           Status = a.Status,
           IsPublished = a.IsPublished,
           IsDeleted = a.IsDeleted,
           UserId = a.UserId,
           DomainId = a.DomainId,
           LevelId = a.LevelId,
           CategoryId = a.CategoryId,
           Translations = a.Translations
               .Where(t => t.Language.Code == languageCode) // Filtrer par langue
               .ToList(), // Charger seulement les traductions dans la langue spécifiée
           Documents = a.Documents, // Charger les autres relations si nécessaire
           Comments = a.Comments
       })
       .FirstOrDefaultAsync();
        }

        public async Task UpdateArticleAsync(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
