

public class Shop{

    private List<Product> inventory;

    public Shop(){
        inventory = new List<Product>();
    }

    public void addProduct(Product product){
        inventory.Add(product);
    }

    public void showAllProducts(){

        foreach(Product product in inventory){
            product.getProductInfo();
        }
    }
}