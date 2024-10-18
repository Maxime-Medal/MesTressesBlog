using AutoMapper;
using Data.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                CreateMap<Article, ArticleDTO>();

                CreateMap<ArticleTranslation, ArticleTranslationDTO>();
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
