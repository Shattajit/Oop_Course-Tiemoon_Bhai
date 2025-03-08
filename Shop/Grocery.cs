public class Grocery: Product{

   public DateTime expiryDate {get; set;}

    public Grocery(string groceryName, double price, DateTime expiryDate):base(groceryName, price){
       this.expiryDate = expiryDate;
    }

    public override void getProductInfo(){
        Console.WriteLine($"Grocery: {getProductName()} and price: {getProductPrice()}");
    } 

}