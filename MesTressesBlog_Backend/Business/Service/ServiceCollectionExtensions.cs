using Business.Service.Interfaces;
using Data.Repository.Interface;
using Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterInternalService(this IServiceCollection services)
        {
            // Injection des services
           services.AddScoped<IArticleService, ArticleService>();

            // Injection des repositories
            services.AddScoped<IArticleRepository, ArticleRepository>();
            
            return services;
        }

    }
}
