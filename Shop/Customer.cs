class Customer
{
    public string Name { get; set; }
    public List<Product> Cart { get; set; } = new List<Product>();
    private Shop shop;  // Reference to the shop

    public Customer(string name, Shop shop)
    {
        Name = name;
        this.shop = shop;
    }

    public void BuyProduct(int id)
    {
        Product product = shop.GetProductById(id);
        if (product != null)
        {
            Cart.Add(product);
            Console.WriteLine($"{Name} bought {product.Name} for {product.Price}$");
        }
        else
        {
            Console.WriteLine($"Product with ID {id} not found!");
        }
    }

    public void ShowCart()
    {
        Console.WriteLine($"\n{Name}'s Cart:");
        if (Cart.Count == 0)
        {
            Console.WriteLine("Cart is empty!");
            return;
        }
        foreach (var item in Cart)
        {
            item.DisplayProductInfo();
        }
    }
}
