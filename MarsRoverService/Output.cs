namespace MarsRoverService
{
    public static class Output
    {
        public static void PrintVehicleCurrentPosition(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.GetCurrentPosition());
        }

        public static void PrintAllRoverPositions(List<Vehicle> rovers)
        {
            Console.WriteLine("Rovers' final positions:");
            foreach (Rover rover in rovers)
            {
                PrintVehicleCurrentPosition(rover);
            }
        }

    }
}