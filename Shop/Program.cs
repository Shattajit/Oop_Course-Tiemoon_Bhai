

class Program{

    public static void Main(string[] args){

        Customer customer = new Customer("Shattajit");

        Product product1 = new Grocery("Milk", 2.50, new DateTime(2025, 5, 1));  
        Product product2 = new Accesories("Headphones", 150.75, "Sony"); 

        customer.Buy(product1);
        customer.Buy(product2);

        customer.Checkout();
    }
}