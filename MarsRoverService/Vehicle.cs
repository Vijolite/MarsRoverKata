using System;
using System.Linq;


namespace MarsRoverService
{
    public abstract class Vehicle : IVehicle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
        public Vehicle(int x, int y, char direction)
        {
            X = x; Y = y; Direction = direction; 
        }
        public Vehicle(string position)
        {
            var pos = position.Split();
            X = Convert.ToInt32(pos[0]); Y = Convert.ToInt32(pos[1]); Direction = Convert.ToChar(pos[2]);
        }
        public string GetCurrentPosition()
        {
            return ($"{X} {Y} {Direction}");
        }
        public void PrintCurrentPosition ()
        {
            Console.WriteLine(this.GetCurrentPosition());
        }
        public void SpinLeft()
        {
            if (Direction.Equals('N')) Direction = 'W';
            else if (Direction.Equals('W')) Direction = 'S';
            else if (Direction.Equals('S')) Direction = 'E';
            else if (Direction.Equals('E')) Direction = 'N';

        }
        public void SpinRight()
        {
            if (Direction.Equals('N')) Direction = 'E';
            else if (Direction.Equals('W')) Direction = 'N';
            else if (Direction.Equals('S')) Direction = 'W';
            else if (Direction.Equals('E')) Direction = 'S';

        }
    }
}
