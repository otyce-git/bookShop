using FastEndpoints;
using Microsoft.AspNetCore.Builder;

namespace BookShop.Modules.BookModule;

public class ListBooksResponse
    {
        public List<BookResponse>? Books {get; set;}
    }

public class BookEndpoints(IBookService bookService)
    : EndpointWithoutRequest<List<BookResponse>>
{
    private readonly IBookService _bookService = bookService;

    public override void Configure()
    {
        Get("api/books");
        AllowAnonymous();
    }
    
     public override Task<List<BookResponse>> ExecuteAsync(CancellationToken ct)
    {
        return Task.FromResult(_bookService.ListBooks());
    }
    
}
