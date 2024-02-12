using BookWise.Core.Contracts;
using BookWise.Core.Services;
using BookWise.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BookWiseServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) 
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IBookService, BookService>();

            return services;
        }
    }
}
