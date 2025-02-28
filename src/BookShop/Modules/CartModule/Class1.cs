using System.Globalization;
using Microsoft.AspNetCore.Builder;

namespace BookShop.Modules.CartModule;

public interface IBookService
{
    IEnumerable<BookResponse> ListBooks();
}

public record BookResponse(Guid Id, string Title, string Author)
{
}

public class BookService : IBookService
{
    public IEnumerable<BookResponse> ListBooks()
    {
       return [
            new BookResponse(Guid.NewGuid(), "The Fellowship of the ring", "J.R.R Tolkien"),
            new BookResponse(Guid.NewGuid(), "The Two Towers", "J.R.R Tolkien"),
            new BookResponse(Guid.NewGuid(), "The Return of the King", "J.R.R Tolkien")
       ];
    }
}

public static class BookEndpoints
{

    public static void MapBookEndpoints(this WebApplication app){
        app.Map("/books", (IBookService bookService) =>{
            return bookService.ListBooks();

        });
    }

    
}
