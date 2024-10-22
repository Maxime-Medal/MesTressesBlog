using AutoMapper;
using Data.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Business.Mapper
{
    public static class AutoMapperExtensions
    {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }

        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                CreateMap<Article, ArticleWithTranslationsDTO>()
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.Name));
                    //.ForMember(dest => dest.Domain, opt => opt.MapFrom(src => src.Domain.DomainTranslations))
                    //.ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Level.LevelTranslations));

                CreateMap<ArticleTranslationDTO, ArticleSimpleTranslationDTO>();

                CreateMap<BaseInfo, BaseInfoDTO>();
                CreateMap<Category, CategoryDTO>();
                CreateMap<CategoryTranslation, CategoryTranslationDTO>();
                CreateMap<Classroom, ClassroomDTO>();
                CreateMap<Comment, CommentDTO>();
                CreateMap<Competence, CompetenceDTO>();
                CreateMap<Document, DocumentDTO>();
                CreateMap<DocumentTranslation, DocumentTranslationDTO>();
                CreateMap<Domain, DomainDTO>();
                CreateMap<DomainTranslation, DomainTranslationDTO>();
                CreateMap<Grade, GradeDTO>();
                CreateMap<Language, LanguageDTO>();
                CreateMap<Level, LevelDTO>();
                CreateMap<LevelTranslation, LevelTranslationDTO>();
                CreateMap<Role, RoleDTO>();
                CreateMap<Student, StudentDTO>();
                CreateMap<StudentClassroom, StudentClassroomDTO>();
                CreateMap<User, UserDTO>();
            }
        }
    }
}



//AutoMapper.AutoMapperMappingException: Error mapping types.



//Mapping types:

//Article->ArticleWithTranslationsDTO

//Data.Models.Article->Data.Models.ArticleWithTranslationsDTO



//Type Map configuration:

//Article->ArticleWithTranslationsDTO

//Data.Models.Article->Data.Models.ArticleWithTranslationsDTO



//Destination Member:

//Translations



// --->AutoMapper.AutoMapperMappingException: Missing type map configuration or unsupported mapping.



//Mapping types:

//ArticleTranslation->ArticleTranslationDTO

//Data.Models.ArticleTranslation->Data.Models.ArticleTranslationDTO

//   at lambda_method443(Closure, ArticleTranslation, ArticleTranslationDTO, ResolutionContext)

//   at lambda_method438(Closure, Object, ArticleWithTranslationsDTO, ResolutionContext)

//   ---End of inner exception stack trace ---

//   at lambda_method438(Closure, Object, ArticleWithTranslationsDTO, ResolutionContext)

//   at Business.Service.ArticleService.GetArticleByIdAsync(Int32 id) in D:\Projects\MesTressesBlog\MesTressesBlog_Backend\Business\Service\ArticleService.cs:line 30

//   at lambda_method5(Closure, Object)



