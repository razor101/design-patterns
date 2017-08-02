using System;
using design_patterns.AdapterPattern;
using design_patterns.BuilderPattern;
using design_patterns.CommandPattern;
using design_patterns.FactoryPattern;

namespace design_patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Factory
            FactoryModel factoryModel = Factory.Create("My Factory Name", 42);

            // Builder
            CarBuilder carBuilder = new CarBuilder();
            carBuilder.SetMake("Audi");
            carBuilder.SetModel("R8");
            carBuilder.SetHorsePower(605);
            Car carResults = carBuilder.BuildCar();

            // Command
            ICommandHandler commandHandler = new CommandHandler();
            var foundUserName = commandHandler.ExecuteWithResults(new LookupUserCommand("john@doe.net"));
            var createdUserName = commandHandler.ExecuteWithResults(new CreateUserCommand("John Doe", "john@doe.net", "johnrulez"));

            // Adapter
            VehicleAdapter vehicleAdapter = new VehicleAdapter(new Vehicle());
            vehicleAdapter.Fly(); // The vehicle flies!

            // Repository - se playtime repo på GitHub @ https://github.com/razor101/playtime
            // Service - se playtime repo på GitHub @ https://github.com/razor101/playtime

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
