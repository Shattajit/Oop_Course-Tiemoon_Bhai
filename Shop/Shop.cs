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
        foreach(Product product in Products)
        {
            product.DisplayProductInfo();
            /*
                though product class is a abstarct class so we can't create an object of it but
                List<Product> is storing grocery and accesories objects from caller side
                ex:  shop.AddProduct(new Grocery(1, "Milk", 1.5, "2025-03-01"));
                so it's a dynamic method dispatch... it's using reference of product class and storing object
                of the subclass grocery and aceesories.. so when we call product.DisplayProductInfo() it
                will run the overridden method in the sub class... cool!!
            */
        }
    }

    public Product GetProductById(int id)
    {
        return Products.Find(p => p.Id == id);
    }
}