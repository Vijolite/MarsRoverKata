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
            MissionControl missionControl = new MissionControl(plateau);
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
            MissionControl mc = new MissionControl(new Plateau(5, 5));
            var rover1 = new Rover("4 4 W");
            var rover2 = new Rover("4 4 S");
            mc.AddRover(rover1);
            Action act = () => mc.AddRover(rover2);
            act.Should().Throw<Exception>().WithMessage("The square is not empty");
        }
        [TestMethod]
        public void TestAddRoverToTheSquareOutsideThePlateau()
        {
            MissionControl mc = new MissionControl(new Plateau(5, 5));
            var rover1 = new Rover("10 10 W");
            Action act = () => mc.AddRover(rover1);
            act.Should().Throw<Exception>().WithMessage("The square is outside the plateau");
        }
        [TestMethod]
        public void TestAddTwoRoversToTheDifferentSquares()
        {
            MissionControl mc = new MissionControl(new Plateau(5, 5));
            var rover1 = new Rover("4 4 W");
            var rover2 = new Rover("5 5 S");
            mc.AddRover(rover1);
            Action act = () => mc.AddRover(rover2);
            act.Should().NotThrow();
        }
        [TestCase("4 4 W", "3 4 W")]
        [TestCase("3 3 S", "3 2 S")]
        [TestCase("3 4 E", "4 4 E")]
        [TestCase("1 1 N", "1 2 N")]
        public void TestMoveRoverForward(string initial, string result)
        {
            MissionControl mc = new MissionControl(new Plateau(5, 5));
            var rover = new Rover(initial);
            mc.AddRover(rover);
            mc.MoveRoverForward(rover);
            rover.GetCurrentPosition().Should().Be(result);
        }
        [TestMethod]
        public void TestMoveRoverForwardToNotEmptySquare()
        {
            MissionControl mc = new MissionControl(new Plateau(5, 5));
            var rover1 = new Rover("4 4 W");
            var rover2 = new Rover("3 4 S");
            mc.AddRover(rover1);
            mc.AddRover(rover2);
            Action act = () => mc.MoveRoverForward(rover1);
            act.Should().Throw<Exception>().WithMessage("Wrong square to move: outside the plateau or not empty");
        }
        [TestCase("1 2 N", "LMLMLMLMM", "1 3 N")]
        [TestCase("3 3 E", "MMRMMRMRRM", "5 1 E")]
        public void TestOneRoverMakingJurney(string initial, string journey, string result)
        {
            MissionControl mc = new MissionControl(new Plateau(5, 5));
            var rover = new Rover(initial);
            mc.AddRover(rover);
            mc.MakeRoverToMakeJourney(rover, journey);
            rover.GetCurrentPosition().Should().Be(result);
        }
        [TestMethod]
        public void TestTwoRoversNotCrossing()
        {
            MissionControl mc = new MissionControl(new Plateau(5, 5));
            var rover1 = new Rover("1 2 N");
            var rover2 = new Rover("3 3 E");
            mc.AddRover(rover1);
            mc.AddRover(rover2);
            mc.MakeRoverToMakeJourney(rover1, "LMLMLMLMM");
            mc.MakeRoverToMakeJourney(rover2, "MMRMMRMRRM");
            (rover1.GetCurrentPosition()+" "+ rover2.GetCurrentPosition()).Should().Be("1 3 N"+" "+ "5 1 E");
        }
        [TestMethod]
        public void TestTwoRoversCrossing()
        {
            MissionControl mc = new MissionControl(new Plateau(5, 5));
            var rover1 = new Rover("1 2 N");
            var rover2 = new Rover("3 3 W");
            mc.AddRover(rover1);
            mc.AddRover(rover2);
            mc.MakeRoverToMakeJourney(rover1, "LMLMLMLMM");
            Action act = () => mc.MakeRoverToMakeJourney(rover2, "MMRMMRMRRM");
            act.Should().Throw<Exception>().WithMessage("Wrong square to move: outside the plateau or not empty");
        }

    }
}