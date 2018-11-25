﻿using NUnit.Framework;
using System;
using Moq;

namespace turtle.Tests
{
    [TestFixture()]
    public class turtleTests
    {
        [Test()]
        public void TestCase()
        {
            Turtle turtle = new Turtle();
            Assert.AreEqual(true, turtle.canYouSeeMe);
        }

        [Test]
        public void CanDrawTurtle()
        {
            var surfaceMockObj = new Mock<ISurface>();
            Turtle turtle = new Turtle();

			var expectedLocation = new Point();
			turtle.position = expectedLocation;

            //turtle will know its location
            turtle.Draw(surfaceMockObj.Object);

            surfaceMockObj.Verify((surface) => surface.DrawAt(expectedLocation));
        }
    }
}
