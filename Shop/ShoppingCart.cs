

public class ShoppingCart{

    private List<Product> cart;

    public ShoppingCart(){
        cart = new List<Product>();
    }

    public void addToCart(Product product){
        cart.Add(product);
    }

    public void removeFromCart(Product product){
        
        for(int i=0;i<cart.Count;i++){
            if(cart[i] == product){
                cart.RemoveAt(i);
                return;
            }
        }
    }

    public void showProductsInCart(){

        foreach(Product product in cart){
            product.getProductInfo();
        }
    }
}