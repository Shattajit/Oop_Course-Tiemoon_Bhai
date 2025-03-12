class Grocery : Product
{
    public string ExpiryDate { get; set; }

    public Grocery(int id, string name, double price, string expiryDate)
        : base(id, name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"ID: {Id} | Grocery: {Name}, Price: {Price}$, Expiry: {ExpiryDate}");
    }
}