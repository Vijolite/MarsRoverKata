using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using NUnit.Framework;


namespace MarsRoverService.Tests
{
    [TestClass]

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Plateau plateau = new Plateau(5, 5);
        }
      

        [TestCase("4 4 W", "4 4 S")]
        [TestCase("3 3 S", "3 3 E")]
        [TestCase("3 4 E", "3 4 N")]
        [TestCase("0 0 N", "0 0 W")]
        public void TestRoverSpinLeft(string initial, string result)
        {
            var rover = new Rover(initial);
            rover.SpinLeft();
            rover.GetCurrentPosition().Should().Be(result);
        }
        [TestCase("4 4 W", "4 4 N")]
        [TestCase("3 3 S", "3 3 W")]
        [TestCase("3 4 E", "3 4 S")]
        [TestCase("0 0 N", "0 0 E")]
        public void TestRoverSpinRight(string initial, string result)
        {
            var rover = new Rover(initial);
            rover.SpinRight();
            rover.GetCurrentPosition().Should().Be(result);
        }
        [TestMethod]
        public void TestAddTwoRoversToTheSameSquare()
        {
            Plateau plateau = new Plateau(5, 5);
            var rover1 = new Rover("4 4 W");
            var rover2 = new Rover("4 4 S");
            plateau.AddRover(rover1);
            Action act = () => plateau.AddRover(rover2);
            act.Should().Throw<Exception>().WithMessage(("The square is not empty"));
        }
        [TestMethod]
        public void TestAddTwoRoversToTheDifferentSquares()
        {
            Plateau plateau = new Plateau(5, 5);
            var rover1 = new Rover("4 4 W");
            var rover2 = new Rover("5 5 S");
            plateau.AddRover(rover1);
            Action act = () => plateau.AddRover(rover2);
            act.Should().NotThrow();
        }

    }
}