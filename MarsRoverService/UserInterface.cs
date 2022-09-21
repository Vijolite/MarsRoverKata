namespace MarsRoverService
{
    public static class UserInterface
    {
        public static Plateau InputPlateauInfo()
        {
            Console.WriteLine("Input the size of the Plateau: length width");
            int length=0;
            int width=0;
            while (length==0 || width==0)
            {
                string input = Console.ReadLine();
                var size = input.Split();
                if (size.Length != 2) Console.WriteLine("You should enter two numbers with a space between them. Try again!");
                else
                {
                    var theFirstIsNumber = int.TryParse(size[0], out length);
                    var theSecondIsNumber = int.TryParse(size[1], out width);
                    if (!theFirstIsNumber || !theSecondIsNumber)
                    {
                        Console.WriteLine("You should enter two numbers. Try again!");
                    }
                }
            }
            var plateau = new Plateau(length, width);
            return plateau;
        }

        public static int InputNumberOfRovers(Plateau plateau)
        {
            Console.WriteLine("Input the the number of rovers");
            int count = 0;
            int maxCount = plateau.Size();
            while (count == 0 || count > maxCount)
            {
                string input = Console.ReadLine();
                var theInputIsNumber = int.TryParse(input, out count);;
                if (!theInputIsNumber)
                {
                    Console.WriteLine("You should enter a number. Try again!");
                }
                else
                    if (count > maxCount) Console.WriteLine($"The number of rovers should be <= by the possible numbers of rovers {maxCount}. Try again!");
            }
            return count;
        }

        public static string InputRoverPosition(int n)
        {
            Console.WriteLine($"Input the initial position for the rover Nr{n}");
            string input="";
            bool theThirdIsDirection = false;
            bool theFirstIsNumber = false;
            bool theSecondIsNumber = false;
            while (!theFirstIsNumber || !theSecondIsNumber || !theThirdIsDirection)
            {
                input = Console.ReadLine();
                var inputArr = input.Split();
                if (inputArr.Length != 3) Console.WriteLine("You should enter two numbers and a direction (N,S,E,W). Try again!");
                else
                {
                    int x;
                    int y;
                    theFirstIsNumber = int.TryParse(inputArr[0], out x);
                    theSecondIsNumber = int.TryParse(inputArr[1], out y);
                    theThirdIsDirection = (inputArr[2] == "N" || inputArr[2] == "S" || inputArr[2] == "W" || inputArr[2] == "E");
                    if (!theFirstIsNumber || !theSecondIsNumber || !theThirdIsDirection)
                    {
                        Console.WriteLine("You should enter two numbers and a direction (N,S,E,W). Try again!");
                    }
                }
            }
            return input;
        }

        public static string InputRoverInstructions()
        {
            Console.WriteLine($"Input the instructions for this rover");
            string input = "";
            bool contaicontainOnlyLRM = false;
            while (!contaicontainOnlyLRM)
            {
                input = Console.ReadLine();
                foreach (char letter in input)
                {
                    contaicontainOnlyLRM = (letter == 'L' || letter == 'R' || letter == 'M');
                    if (!contaicontainOnlyLRM)
                    {
                        Console.WriteLine("The instruction should contain only commands L, R, M. Try again!");
                        break;
                    }
                        
                }
            }
            return input;
        }
    }
}