using System;

public class Car
{
    public string owner {get; set;}
    public string manufacturer {get; set;}
    public string model {get; set;}
    public int yearOfManufacture {get; set;}

    public License license {get; set;}

    public Car(string owner, string manufacturer, string model, int yearOfManufacture, License license)
    {
        this.owner = owner;
        this.manufacturer = manufacturer;
        this.model = model;
        this.yearOfManufacture = yearOfManufacture;
        this.license = license;
    }
    public int CalculateAge()
    {
        return DateTime.Now.Year - yearOfManufacture;
    }

    public bool CanRenewRegistration()
    {
        return CalculateAge() <= 20;
    }

 public void DisplayInfo()
    {
        Console.WriteLine($"Owner: {owner}");
        Console.WriteLine($"Car: {manufacturer} {model} ({yearOfManufacture})");
        Console.WriteLine($"Plate: {license.plateNumber}");
        Console.WriteLine($"Registration: {license.registrationDate.ToShortDateString()} to {license.expirationDate.ToShortDateString()}");
        Console.WriteLine($"License Valid: {license.isValid()}");
        Console.WriteLine($"Car Age: {CalculateAge()} years");
        Console.WriteLine($"Eligible for Renewal: {CanRenewRegistration()}");
    }
}