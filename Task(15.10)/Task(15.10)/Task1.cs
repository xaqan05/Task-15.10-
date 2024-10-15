/*namespace Task_15._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Hyundai", "Elantra", 30, 2, 50);
            car.Drive(15);
            car.ShowInfo();

        }
    }

    class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1km;
        public double Millage;


        public Car(string brand, string model, double currentFuel, double fuelFor1Km, double millage)
        {
            this.Brand = brand;
            this.Model = model;
            this.CurrentFuel = currentFuel;
            this.FuelFor1km = fuelFor1Km;
            this.Millage = millage;
        }

        public void Drive(double km)
        {
            double required = km * FuelFor1km;

            if (required <= CurrentFuel)

            {
                Millage += km;
                CurrentFuel -= required;
            }
            else
            {
                {
                    Console.WriteLine("Benzin yeterli deyil");
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Current Fuel: {CurrentFuel}, Fuel For 1km: {FuelFor1km}, Millage:{Millage}");
        }

    }
}
*/