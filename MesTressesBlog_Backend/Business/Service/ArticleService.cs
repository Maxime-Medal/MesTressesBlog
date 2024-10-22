using AutoMapper;
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
        private readonly IMapper _mapper;
        public ArticleService(
            IArticleRepository articleRepository,
            IMapper mapper
            )
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        public async Task<ArticleWithTranslationsDTO> GetArticleByIdAsync(int id)
        {
            var article = await _articleRepository.GetArticleByIdAsync(id);  // TODO
            // récupération tu repository et conversion en DTO
            var newArticleDTO = _mapper.Map<ArticleWithTranslationsDTO>( article );

            return newArticleDTO;
        }
        public async Task<ArticleWithTranslationsDTO> GetArticleByIdWithTranslationAsync(int id, string languageCode)
        {
                await _articleRepository.GetArticleByIdWithTranslationAsync(id, languageCode);  // TODO
            return new ArticleWithTranslationsDTO(); 
        }
        public async Task<IEnumerable<ArticleWithTranslationsDTO>> GetAllArticlesAsync()
        {
                await _articleRepository.GetAllArticlesAsync(); // TODO
            return new List<ArticleWithTranslationsDTO>();
        }
        public Task<int> AddArticleAsync()
        //public async Task<int> AddArticleAsync()
        {
            throw new NotImplementedException();  // TODO
        }
        public Task<ArticleWithTranslationsDTO> UpdateArticleAsync()
        //public async Task<Article> UpdateArticleAsync()
        {
            throw new NotImplementedException(); // TODO
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
