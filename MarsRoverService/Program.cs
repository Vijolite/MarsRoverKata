namespace MarsRoverService
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var size = input.Split().Select(x=>Convert.ToInt32(x)).ToArray();
            var plateau = new Plateau(size[0], size[1]);
            var mc = new MissionControl(plateau);
            var roverCount = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i < roverCount; i++)
            {
                var firstPosition = Console.ReadLine();
                var rover = new Rover(firstPosition);
                mc.AddRover(rover);
                var instructions = Console.ReadLine();
                mc.MakeRoverToMakeJourney(rover, instructions);
            }
            mc.PrintAllRoverPositions();
        }
    }
}