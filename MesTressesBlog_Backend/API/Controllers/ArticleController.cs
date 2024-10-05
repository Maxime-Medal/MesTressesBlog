using Business.Service;
using Data.Models;
using Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {

        private readonly ILogger<ArticleController> _logger;
        private readonly IArticleRepository _articleRepository;

        public ArticleController(
            ILogger<ArticleController> logger,
            IArticleRepository articleRepository)
        {
            _logger = logger;
            _articleRepository = articleRepository;
        }

        [HttpGet]
        public Task<Article> GetArticleByIdWithTranslationAsync(int id, string languageCode)
        {
            return _articleRepository.GetArticleByIdWithTranslationAsync(id, languageCode);
        }
    }

}
