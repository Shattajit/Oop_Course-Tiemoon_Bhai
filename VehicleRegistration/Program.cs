License license = new License(
            plateNumber: "XYZ1234",
            registrationDate: new DateTime(2023, 6, 1),
            expirationDate: new DateTime(2025, 6, 1)
        );

 Car car = new Car(
            owner: "John Doe",
            manufacturer: "Toyota",
            model: "Corolla",
            yearOfManufacture: 2010,
            license: license
        );

car.DisplayInfo();