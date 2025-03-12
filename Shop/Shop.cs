class Shop
{
    public List<Product> Products { get; set; } = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void ShowProducts()
    {
        Console.WriteLine("\nAvailable Products:");
        foreach (var product in Products)
        {
            product.DisplayProductInfo();
        }
    }

    public Product GetProductById(int id)
    {
        return Products.Find(p => p.Id == id);
    }
}