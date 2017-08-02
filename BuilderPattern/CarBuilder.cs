namespace design_patterns.BuilderPattern
{
    public class CarBuilder
    {
        private readonly Logger logger;
        
        private string make;

        private string model;

        private int horsePower;

        public CarBuilder(Logger logger)
        {
            this.logger = logger;
        }

        public void SetMake(string make)
        {
            if (string.IsNullOrEmpty(make))
            {
                Logger.Error("make cannot be null or empty.");
                return;
            }

            this.make = make;
        }

        public void SetModel(string model)
        {
            if (string.IsNullOrEmpty(model))
            {
                Logger.Error("model cannot be null or empty.");
                return;
            }

            this.model = model;
        }

        public void SetHorsePower(int horsePower)
        {
            if (horsePower <= 0)
            {
                Logger.Error("horsePower cannot less than or equal to 0.");
                return;
            }

            this.horsePower = horsePower;
        }

        public Car BuildCar()
        {
            return new Car
            {
                Make = this.make,
                Model = this.model,
                HorsePower = this.horsePower
            };
        }
    }
}