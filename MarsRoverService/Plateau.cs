using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverService
{
    public class Plateau
    {
        public int Length { get; private set; }
        public int Width { get; private set; }
        public List <Rover> Rovers { get; set; }
        public Plateau (int length, int width)
        {
            Length = length;
            Width = width;
            Rovers = new List<Rover>();
        }
        public void AddRover (Rover rover)
        {
            if (IsEmptySquare(rover.X, rover.Y)) Rovers.Add(rover);
            else throw new Exception("The square is not empty");
        }
        public void PrintAllRoverPositions()
        {
            foreach (Rover rover in Rovers)
            {
                rover.PrintCurrentPosition();
            }
        }
        public bool IsEmptySquare(int x, int y)
        {
            foreach (Rover rover in Rovers)
            {
                if (rover.X==x && rover.Y==y) return false;
            }
            return true;
        }
    }
}
