namespace BookShop.Modules.BookModule.Domain;

internal class Book
{
    public Guid Id { get; set; } = Guid.NewGuid();    
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public decimal Price { get; set; }

    internal Book (Guid id, string title, string author, decimal price)
    {
        Id = id;
        Title = title;
        Author = author;
        Price = price;
    }

    internal void UpdatePrice(decimal newPrice)
    {
        Price = newPrice;
    }
}