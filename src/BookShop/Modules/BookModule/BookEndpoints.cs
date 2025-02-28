using Microsoft.AspNetCore.Builder;

namespace BookShop.Modules.BookModule;

public static class BookEndpoints
{

    public static void MapBookEndpoints(this WebApplication app){
        app.Map("/books", (IBookService bookService) =>{
            return bookService.ListBooks();

        });
    }
}
