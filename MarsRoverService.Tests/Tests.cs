using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using NUnit.Framework;


namespace MarsRoverService.Tests
{
    [TestClass]
    public class Tests
    {

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

    }
}