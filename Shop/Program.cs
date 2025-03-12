class Program
{
    static void Main()
    {
        // Create Shop and Add Products
        Shop shop = new Shop();
        shop.AddProduct(new Grocery(1, "Milk", 1.5, "2025-03-01"));
        shop.AddProduct(new Grocery(2, "Bread", 2.0, "2025-03-05"));
        shop.AddProduct(new Accessory(3, "Watch", 50, "Rolex"));
        shop.AddProduct(new Accessory(4, "Sunglasses", 30, "RayBan"));

        // Show available products
        shop.ShowProducts();

        // Create Customer
        Customer customer = new Customer("John", shop);

        // Customer buys products by ID
        customer.BuyProduct(1); // Buying Milk
        customer.BuyProduct(3); // Buying Watch
        customer.BuyProduct(10); // Invalid ID

        // Show cart
        customer.ShowCart();
    }
}