public class Accesories: Product{

   public string brand {get; set;}

    public Accesories(string accesoriesName, double price, string brand):base(accesoriesName, price){
       this.brand = brand;
    }

    public override void getProductInfo(){
        Console.WriteLine($"Accesories: {getProductName()} and price: {getProductPrice()}");
    } 

}