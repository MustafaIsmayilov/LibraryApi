using LibraryApi.Application.Abstracts.Repositories;
using LibraryApi.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryApi.Persistence;

public static class ServiceRegistration
{
    public static void RegisterService(this IServiceCollection services)
    {
        //Repos
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        services.AddScoped<IBookImageRepository, BookImageRepository>();
        services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<IReviewRepository, ReviewRepository>();
    }
}
