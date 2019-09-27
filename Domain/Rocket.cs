namespace RocketSimulator.Domain
{
    abstract class Rocket
    {
        public string Name { get; }
        public int FuelAmountInKilograms { get; }
        public int GrossWeight { get; }
        public int ThrustVacuum { get; }
        
        public Rocket(string name, int fuelAmountInKilograms, int grossWeight, int thrustVacuum)
        {
            Name = name;
            FuelAmountInKilograms = fuelAmountInKilograms;
            GrossWeight = grossWeight;
            ThrustVacuum = thrustVacuum;
        }
    }
}
