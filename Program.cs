using System;
using design_patterns.BuilderPattern;
using design_patterns.CommandPattern;

namespace design_patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Builder
            CarBuilder carBuilder = new CarBuilder();
            carBuilder.SetMake("Audi");
            carBuilder.SetModel("R8");
            carBuilder.SetHorsePower(605);
            Car carResults = carBuilder.BuildCar();

            // Command
            ICommandHandler commandHandler = new CommandHandler();
            var createdUserName = commandHandler.ExecuteWithResults<CreateUserCommand, string>(new CreateUserCommand("John Doe", "john@doe.net", "johnrulez"));

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
