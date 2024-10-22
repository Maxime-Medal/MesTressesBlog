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
        public async Task<IEnumerable<Article>> GetAllArticlesAsync()
        {
            try
            {
                return await _context.Articles.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while getting all articles.", ex); // TODO exeption à gérer

            }
        }

        public async Task<Article> GetArticleByIdWithTranslationAsync(int id, string languageCode)
        {
            var newArticle = new Article();
            try
            {
                newArticle = await _context.Articles
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
                        Translations = a.Translations.Where(t => t.Language!.Code == languageCode).ToList(),
                        Documents = a.Documents.Where(d => d.ArticleId == id).ToList(),
                        Comments = a.Comments.Where(c => c.ArticleId == id).ToList(),
                        BaseInfo = a.BaseInfo,
                    })
                    .FirstOrDefaultAsync();

                if (newArticle == null)
                {
                    throw new FileNotFoundException($"Article with ID {id} not found."); // TODO exeption à gérer
                }

                return newArticle;
            }
            catch (Exception ex)
            {

                throw new Exception("An error occurred while fetching the article.", ex); // TODO exeption à gérer
            }
        }

        public async Task<Article> GetArticleByIdAsync(int id)
        {
            try
            {
                var newArticle = await _context.Articles
                    .Where(a => a.Id == id)
                    .Include(a => a.Translations)
                    .Include (a => a.Documents)
                    .Include (a => a.Comments)
                    .Include (a => a.Domain)
                    .Include (a => a.Level)
                    .Include (a => a.Category)
                    .FirstOrDefaultAsync();
                if (newArticle == null)
                {
                    throw new FileNotFoundException($"Article with ID {id} not found.");
                }
                return newArticle;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while getting the full article.", ex); // TODO exeption à gérer
            }
        }

        public async Task<int> AddArticleAsync(Article article)
        {
            try
            {
                _context.Articles.Add(article);
                await _context.SaveChangesAsync();
                return article.Id;
            }
            catch (Exception ex)
            {

                throw new Exception("An error occurred while adding the article.", ex); // TODO exeption à gérer
            }
        }

        public async Task<int> UpdateArticleAsync(Article article)
        {
            try
            {
                var articleToUpdate = await _context.Articles.FindAsync(article.Id);
                if (articleToUpdate == null)
                {
                    throw new FileNotFoundException($"Article with ID {article.Id} not found."); // TODO exeption à gérer
                }
                articleToUpdate = article;
                _context.Articles.Update(articleToUpdate);
                await _context.SaveChangesAsync();
                return articleToUpdate.Id;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the article.", ex); // TODO exeption à gérer
            }
        }

        public async Task<bool> DeleteArticleAsync(int id)
        {
            try
            {
                var articleToDelete = await _context.Articles.FindAsync(id);
                if (articleToDelete != null)
                {
                    _context.Articles.Remove(articleToDelete);
                }
                if (articleToDelete == null)
                {
                    throw new FileNotFoundException($"Article with ID {id} not found."); // TODO exeption à gérer
                }

                return await _context.SaveChangesAsync() > 0;

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the article.", ex); // TODO exeption à gérer
            }

        }
    }
}
