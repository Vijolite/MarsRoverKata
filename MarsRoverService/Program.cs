

namespace MarsRoverService
{
    public class Program
    {
        public static void Main()
        {
            var plateau = UserInterface.InputPlateauInfo();
            var mc = new MissionControl(plateau);
            var roverCount = UserInterface.InputNumberOfRovers(plateau);
            for (int i = 0; i < roverCount; i++)
            {
                var firstPosition = UserInterface.InputRoverPosition(i + 1);
                var rover = new Rover(firstPosition);
                mc.AddRover(rover);
                var instructions = UserInterface.InputRoverInstructions();
                mc.MakeRoverToMakeJourney(rover, instructions);
            }
            Output.PrintAllRoverPositions(mc.Rovers);
        }
    }
}