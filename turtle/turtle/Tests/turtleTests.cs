using NUnit.Framework;
using System;
using Moq;

namespace turtle.Tests
{
    [TestFixture()]
    public class turtleTests
    {
        [Test]
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

            char headOfTurtle = '>';

            var expectedLocation = new Point(0, 0);
            turtle.position = expectedLocation;

            //turtle will know its location
            turtle.Draw(surfaceMockObj.Object);

            //if turtle is at 0,0 
            //we need to see '>' at 0,0
            surfaceMockObj.Verify((surface) => surface.DrawAt(expectedLocation, headOfTurtle));



        }

        [Test]
        public void CanDrawTurtleTrailWithNewMoveFunction()
        {
            //moves from 0,0 to 1,0 (moving right)
            //we need to see '-' at 0,0 and '>' at 1,0

            var surfaceMockObj = new Mock<ISurface>();
            Turtle turtle = new Turtle(surfaceMockObj.Object);

            char headOfTurtle = '>';
            char trail = '-';

            var startingLocation = new Point(0, 0);
            turtle.position = startingLocation;

            var endingLocation = new Point(1, 0);

            //turtle will know its location
            turtle.Draw(surfaceMockObj.Object);

            surfaceMockObj.Verify((surface) => surface.DrawAt(startingLocation, headOfTurtle));

            turtle.Move();

            surfaceMockObj.Verify((surface) => surface.DrawAt(It.IsAny<Point>(), headOfTurtle), Times.Exactly(2));
            surfaceMockObj.Verify((surface) => surface.DrawAt(endingLocation, headOfTurtle));
            surfaceMockObj.Verify((surface) => surface.DrawAt(startingLocation, trail));
        }

        [Test]
        public void CanSeeTurtleMoveOnCamera()
        {
            Camera camera = new Camera();

            var surfaceMockObj = new Mock<ISurface>();
            Turtle turtle = new Turtle(surfaceMockObj.Object);

            char headOfTurtle = '>';
            //char trail = '-';

            var startingLocation = new Point(0, 0);
            turtle.position = startingLocation;

            int unitsOfMovement = 5;           //steps

            camera.Record(turtle, unitsOfMovement);

            surfaceMockObj.Verify((surface) => surface.DrawAt(It.IsAny<Point>(), headOfTurtle), Times.Exactly(5));
        }

        [Test]
        public void CanControlSpeedOfCamera()
        {
            Camera camera = new Camera();

            int expectedDefaultSpeed = 10;
            Assert.AreEqual(expectedDefaultSpeed, camera.MovementsPerSecond);

			int expectedNewSpeed = 5;
            camera.MovementsPerSecond = expectedNewSpeed;
			Assert.AreEqual(expectedNewSpeed, camera.MovementsPerSecond);
        }
    }
}
