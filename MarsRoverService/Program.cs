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
            //var r = new Rover("0 0 N");
            //r.PrintCurrentPosition();
            //Console.WriteLine(r.Direction);
            //if (r.Direction == 'N') r.Direction = 'W';
            //r.SpinLeft();
            //r.Direction = 'Q';
            //r.PrintCurrentPosition();
            //mc.AddRover(new Rover("0 0 N"));
            //mc.PrintAllRoverPositions();

            //MissionControl mc = new MissionControl(new Plateau(5, 5));
            var rover1 = new Rover("1 2 N");
            //var rover2 = new Rover("3 4 S");
            mc.AddRover(rover1);
            //mc.AddRover(rover2);
            //rover1.PrintCurrentPosition();
            //rover2.PrintCurrentPosition();
            mc.MakeRoverToMakeJourney(rover1, "LMLMLMLMM");
            mc.PrintAllRoverPositions();
            //mc.MoveRoverForward(rover1);
            //mc.PrintAllRoverPositions();

        }

    }
}