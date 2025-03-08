
public abstract class Product{

    private string productName;

    private double productPrice;

    public Product(string productName, double productPrice){
        this.productName = productName;
        this.productPrice = productPrice;
    }

    public string getProductName(){
        return productName;
    }

    public double getProductPrice(){
        return productPrice;
    }

    public abstract void getProductInfo();
}