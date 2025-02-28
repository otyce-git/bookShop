namespace BookShop.Modules.BookModule;

internal interface IBookService
{
    IEnumerable<BookResponse> ListBooks();
}
