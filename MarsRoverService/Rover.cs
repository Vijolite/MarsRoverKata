using System;

namespace MarsRoverService
{
    public class Rover : Vehicle
    {
        public string Name;
        public Rover (int x, int y, char direction) : base (x, y, direction)
        {
            Name = "";
        }
        public Rover(string position) : base (position)
        {
            Name = "";
        }
        public void MakePhotos()
        {

        }
        public void ReceiveName(string name)
        {
            Name = name;
        }
        public void PrintAllInfo()
        {
            Console.WriteLine($"{Name} {GetCurrentPosition()}");
        }
    }
}
