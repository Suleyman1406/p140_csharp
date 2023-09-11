//Vehicle.PrintVehicleCount();


//// Model, WheelCount, Color
Vehicle vehicle = new Vehicle("Vaz 2107", 4, "white");

//vehicle.PrintVehicleInfo();

//Vehicle.PrintVehicleCount();

//// HasABS
Motorcycle motorcycle = new Motorcycle("Pulsar NS200", 2, "gray", false);

//motorcycle.PrintVehicleInfo();

//Vehicle.PrintVehicleCount();

//// DoorCount
Car car = new Car("Mercedes E240", 4, "red", 4);

//car.PrintVehicleInfo();

//Vehicle.PrintVehicleCount();

// BatteryLife
ElectricCar electricCar = new ElectricCar("Togg T10X", 4, "Blue", 4, 99);

//electricCar.PrintVehicleInfo();

//Vehicle.PrintVehicleCount();

//// EngineVolume
FuelCar fuelCar = new FuelCar("Fiat Tofash 124", 4, "gold", 4, 1600);

fuelCar.PrintVehicleInfo();

Vehicle.PrintVehicleCount();


Vehicle[] vehicles = { vehicle, motorcycle, car, electricCar, fuelCar };

foreach (Vehicle v in vehicles)
{
    v.PrintVehicleInfo();
}

