

public class Customer{

     public ShoppingCart cart { get; set; }

    private string name;

    public Customer(string name){
        cart = new ShoppingCart();
        this.name = name;
    }

    public void addToCart(Product product){
        cart.addToCart(product);
    }

    public void showProductsInCart(){

        cart.showProductsInCart();
    }

    public void Buy(Product product)
    {
        if (product != null)
        {
            cart.addToCart(product);
        }
        else
        {
            Console.WriteLine("Product not found in shop.");
        }
    }

    public void Checkout()
    {
        Console.WriteLine($"\n{name}'s Order Summary:");
        cart.showProductsInCart();
    }
}