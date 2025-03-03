

public class Program{
    public static void Main(string[] args){

        CarRentalSystem rentalSystem = new CarRentalSystem();
        
        Car car1 = new Car("Toyota Corolla", 12, "Red", "Sedan", 50);
        Car car2 = new Car("Honda Civic",13, "Blue", "Sedan", 55);

        rentalSystem.AddCar(car1);
        rentalSystem.AddCar(car2);

        // Show all cars
        rentalSystem.ShowAllCars();

        // Rent a car
        rentalSystem.RentCar("Toyota Corolla", DateTime.Now);

        // Schedule maintenance for a car
        rentalSystem.PerformMaintenance("Honda Civic", DateTime.Now.AddDays(3));

        // Try to rent a car under maintenance
        rentalSystem.RentCar("Honda Civic", DateTime.Now);

        // Show available cars
        rentalSystem.ShowAvailableCars();

        // Return a car
        rentalSystem.ReturnCar("Toyota Corolla", DateTime.Now.AddDays(5));

        // Show car cost
        rentalSystem.ShowCarCost("Honda Civic");

        rentalSystem.RentCar("Honda Civic", DateTime.Now);

        rentalSystem.returnedFormMaintenance(13);

        rentalSystem.RentCar("Honda Civic", DateTime.Now);
    }
}