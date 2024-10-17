using Business.Service.Interfaces;
using Data.Models;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<ArticleDTO> GetFullArticleByIdAsync(int id)
        {
            var article = await _articleRepository.GetFullArticleByIdAsync(id);

            return new ArticleDTO();
        }
        public async Task<Article> GetArticleByIdWithTranslationAsync(int id, string languageCode)
        {
            return await _articleRepository.GetArticleByIdWithTranslationAsync(id, languageCode);
        }
        public async Task<IEnumerable<Article>> GetAllArticlesAsync()
        {
            return await _articleRepository.GetAllArticlesAsync();
        }
        public Task<int> AddArticleAsync()
        //public async Task<int> AddArticleAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Article> UpdateArticleAsync()
        //public async Task<Article> UpdateArticleAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeleteArticleAsync(int id)
        {
            try
            {
            return await _articleRepository.DeleteArticleAsync(id);
                //return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
