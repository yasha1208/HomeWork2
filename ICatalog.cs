namespace WebApplication2;

public interface ICatalog
{
    IReadOnlyCollection<Product> GetProducts();
}