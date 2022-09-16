namespace MarsRoverService
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var size = input.Split().Select(x=>Convert.ToInt32(x)).ToArray();
            var plateau = new Plateau(size[0], size[1]);
            //var r = new Rover("0 0 N");
            //r.PrintCurrentPosition();
            //Console.WriteLine(r.Direction);
            //if (r.Direction == 'N') r.Direction = 'W';
            //r.SpinLeft();
            //r.Direction = 'Q';
            //r.PrintCurrentPosition();
            plateau.AddRover(new Rover("0 0 N"));
            plateau.PrintAllRoverPositions();

        }

    }
}