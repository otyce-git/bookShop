namespace BookShop.Modules.BookModule;

internal class BookService : IBookService
{
    public List<BookResponse> ListBooks()
    {
       return [
            new BookResponse(Guid.NewGuid(), "The Fellowship of the ring", "J.R.R Tolkien"),
            new BookResponse(Guid.NewGuid(), "The Two Towers", "J.R.R Tolkien"),
            new BookResponse(Guid.NewGuid(), "The Return of the King", "J.R.R Tolkien")
       ];
    }
}
