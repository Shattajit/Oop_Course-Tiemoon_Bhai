using System;
public class License
{
    public string plateNumber {get; set;}
    public DateTime registrationDate {get; set;}

    public DateTime expirationDate {get; set;}

    public License(string plateNumber, DateTime registrationDate, DateTime expirationDate)
    {
        this.plateNumber = plateNumber;
        this.registrationDate = registrationDate;
        this.expirationDate = expirationDate;
    }

    public bool isValid()
    {
        return DateTime.Now <= expirationDate;
    }

}