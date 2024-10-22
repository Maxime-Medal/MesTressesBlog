using Business.Service;
using Business.Service.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {

        private readonly ILogger<ArticleController> _logger;
        private readonly IArticleService _articleService;

        public ArticleController(
            ILogger<ArticleController> logger,
            IArticleService articleService)
        {
            _logger = logger;
            _articleService = articleService;
        }

        [HttpGet("{id}/{languageCode}")]
        public Task<ArticleWithTranslationsDTO> GetArticleByIdWithTranslation(int id, string languageCode)
        {
            return _articleService.GetArticleByIdWithTranslationAsync(id, languageCode);
        }

        [HttpGet("{id}")]
        public Task<ArticleWithTranslationsDTO> GetArticleById(int id)
        {
            return _articleService.GetArticleByIdAsync(id);
        }

        [HttpGet]
        public Task<IEnumerable<ArticleWithTranslationsDTO>> GetAllArticles()
        {
            return _articleService.GetAllArticlesAsync();
        }

        [HttpDelete]
        public Task<bool> DeleteArticle(int id)
        {
           return  _articleService.DeleteArticleAsync(id);
        }

    }
}
