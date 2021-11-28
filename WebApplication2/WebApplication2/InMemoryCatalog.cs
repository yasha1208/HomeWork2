namespace WebApplication2;

public class InMemoryCatalog : ICatalog
{
    private IReadOnlyCollection<Product> _products = new Product[]
    {
        new (Name:"Книга 1", Price:100m),
        new (Name:"Книга 1", Price:200m),
        new (Name:"Книга 1", Price:300m),
    };

    public IReadOnlyCollection<Product> GetProducts()
    {
        if (DateTime.UtcNow.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
        {
            return _products.Select(it => new Product(it.Name, 
                it.Price * 1.5m)).ToList();
        }

        return _products;
    } 
}