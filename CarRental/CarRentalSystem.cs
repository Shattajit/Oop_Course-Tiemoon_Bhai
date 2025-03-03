using System;
using System.Collections.Generic;

public class CarRentalSystem
{
    private List<Car> cars;

    public CarRentalSystem()
    {
        cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void ShowAllCars()
    {
        foreach (Car car in cars)
        {
            Console.WriteLine("Car Name: " + car.GetCarName() + ", Color: " + car.GetCarColor());
        }
    }

    public void ShowAvailableCars()
    {
        foreach (Car car in cars)
        {
            if (car.IsAvailable())
            {
                Console.WriteLine("Available Car: " + car.GetCarName());
            }
        }
    }

    public void RentCar(string carName, DateTime rentStartDate)
    {
        foreach (Car car in cars)
        {
            if (car.GetCarName() == carName)
            {
                if (car.IsAvailable())
                {
                    car.RentCar(rentStartDate);
                    Console.WriteLine("Car rented: " + car.GetCarName());
                    return;
                }
                else
                {
                    Console.WriteLine("Car is not available: " + car.GetCarName());
                    return;
                }
            }
        }
        Console.WriteLine("Car not found.");
    }

    public void ReturnCar(string carName, DateTime rentEndDate)
    {
        foreach (Car car in cars)
        {
            if (car.GetCarName() == carName)
            {
                double totalCost = car.CalculateTotalRentCost(rentEndDate);
                Console.WriteLine("Car returned: " + car.GetCarName() + ". Total cost: $" + totalCost);
                car.ReturnCar();
                return;
            }
        }
        Console.WriteLine("Car not found.");
    }

    public void PerformMaintenance(string carName, DateTime maintenanceDate)
    {
        foreach (Car car in cars)
        {
            if (car.GetCarName() == carName)
            {
                car.ScheduleMaintenance(maintenanceDate);
                Console.WriteLine("Scheduled maintenance for: " + car.GetCarName() + " on " + maintenanceDate.ToShortDateString());
                return;
            }
        }
        Console.WriteLine("Car not found.");
    }

    public void returnedFormMaintenance(int carId){

        foreach(Car car in cars){

            if(car.getCarId() == carId){
                car.returnedFormMaintenance();
            }
        }
    }

    public void ShowCarCost(string carName)
    {
        foreach (Car car in cars)
        {
            if (car.GetCarName() == carName)
            {
                Console.WriteLine("The rent cost for " + car.GetCarName() + " is: $" + car.CalculateRentCost());
                return;
            }
        }
        Console.WriteLine("Car not found.");
    }
}
