using Microsoft.Extensions.DependencyInjection;

namespace BookShop.Modules.BookModule;

public static class BookServiceExtensions
{
    public static IServiceCollection AddBookServices(
        this IServiceCollection services
    )
    {
        services.AddScoped<IBookService, BookService>();
        return services;
    }
}
