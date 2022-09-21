using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoverService
{
    public class MissionControl
    {
        public Plateau Plateau { get; set; }
        public List <Rover> Rovers { get; set; }
        public MissionControl (Plateau plateau)
        {
            Plateau = plateau;
            Rovers = new List<Rover>();
        }
        public void AddRover (Rover rover)
        {
            if (!IsValidSquare(rover.X, rover.Y)) throw new Exception("The square is outside the plateau");
            else if (!IsEmptySquare(rover.X, rover.Y)) throw new Exception("The square is not empty");
            else Rovers.Add(rover);
        }
        public void PrintAllRoverPositions()
        {
            Console.WriteLine("Rovers' final positions:");
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
        public bool IsValidSquare(int x, int y)
        {
            return x>=0 && x<=Plateau.Length && y>=0 && y<=Plateau.Width;
        }
        public void MoveRoverForward (Rover rover)
        {
            int x = rover.X;
            int y = rover.Y;
            if (rover.Direction == 'N') y++;
            if (rover.Direction == 'S') y--;
            if (rover.Direction == 'W') x--;
            if (rover.Direction == 'E') x++;
            if (IsValidSquare(x, y) && IsEmptySquare(x, y)) rover.Move(x, y);
            else throw new Exception("Wrong square to move: outside the plateau or not empty");
        }
        public void MakeRoverToMakeJourney(Rover rover, string journey)
        {
            foreach (char command in journey)
            {
                if (command == 'L') rover.SpinLeft();
                if (command == 'R') rover.SpinRight();
                if (command == 'M') MoveRoverForward(rover);
            }
        }
    }
}
