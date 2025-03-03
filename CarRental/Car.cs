public class Car
{
    private string carName;
    private int carId;
    private string carColor;
    private string type;
    private bool isAvailable;
    private DateTime? nextMaintenanceDate;
    private double rentCostPerDay;
    private DateTime? rentStartDate;
    private DateTime? rentEndDate;

    public Car(string carName, int carId, string carColor, string type, double rentCostPerDay)
    {
        this.carName = carName;
        this.carId = carId;
        this.carColor = carColor;
        this.type = type;
        this.rentCostPerDay = rentCostPerDay;
        this.isAvailable = true;
        this.nextMaintenanceDate = null;
        this.rentStartDate = null;
        this.rentEndDate = null;
    }

    public string GetCarName() => carName;
    public int getCarId() => carId;
    public string GetCarColor() => carColor;

    public bool IsAvailable()
    {
        // Car is unavailable if it's under maintenance or rented
        if (nextMaintenanceDate.HasValue && nextMaintenanceDate.Value > DateTime.Now)
        {
            return false;
        }
        return isAvailable && !rentStartDate.HasValue; // Car is unavailable if it's rented
    }

    public void RentCar(DateTime startDate)
    {
        if (!IsAvailable())
        {
            Console.WriteLine("Car is currently unavailable and cannot be rented.");
        }
        else
        {
            rentStartDate = startDate;
            isAvailable = false;
        }
    }

    public void ReturnCar()
    {
        isAvailable = true;
        rentStartDate = null;
        rentEndDate = null; // Clear rent dates
    }

    public void ScheduleMaintenance(DateTime maintenanceDate)
    {
        nextMaintenanceDate = maintenanceDate;
        isAvailable = false;  // Car is unavailable during maintenance
    }

    public void returnedFormMaintenance()
    {
        nextMaintenanceDate = null;
        isAvailable = true; // Car becomes available again after maintenance
        Console.WriteLine("Maintenance performed on: " + carName);
    }

    public double CalculateRentCost()
    {
        // Example: Rent cost is based on car type or a fixed value per day
        return rentCostPerDay;
    }

    public double CalculateTotalRentCost(DateTime rentEndDate)
    {
        if (rentStartDate.HasValue)
        {
            this.rentEndDate = rentEndDate;
            TimeSpan rentalDuration = rentEndDate - rentStartDate.Value;
            double totalCost = rentalDuration.Days * rentCostPerDay;
            return totalCost;
        }
        return 0;
    }

    public DateTime? GetNextMaintenanceDate() => nextMaintenanceDate;
}