// See https://aka.ms/new-console-template for more information
using ODEV1.Classes;

List<Car> cars = new List<Car>
            {
                new Car { Brand = "Toyota", Model = "Corolla", FuelConsumption = 6.5, TotalDistance = 5000 },
                new Car { Brand = "BMW", Model = "X5", FuelConsumption = 9.0, TotalDistance = 5000 },
                new Car { Brand = "Mercedes", Model = "C200", FuelConsumption = 8.2, TotalDistance = 5000 }
            };
foreach (var car in cars)
{
    double totalFuel = car.CalculateTotalFuel();
    Console.WriteLine($"Marka: {car.Brand}, Model: {car.Model}, 100 km'de Yaktığı Yakıt: {car.FuelConsumption} litre, Toplam Yakıt Tüketimi: {totalFuel} litre");
}


