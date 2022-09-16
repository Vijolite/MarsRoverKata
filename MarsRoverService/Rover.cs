using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverService
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
        public Rover (int x, int y, char direction)
        {
            X = x; Y = y; Direction = direction; 
        }
        public Rover(string position)
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
