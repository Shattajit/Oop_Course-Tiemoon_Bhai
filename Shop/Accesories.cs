class Accessory : Product
{
    public string Brand { get; set; }

    public Accessory(int id, string name, double price, string brand)
        : base(id, name, price)
    {
        Brand = brand;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"ID: {Id} | Accessory: {Name}, Price: {Price}$, Brand: {Brand}");
    }
}