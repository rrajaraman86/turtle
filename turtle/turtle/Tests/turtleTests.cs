using NUnit.Framework;
using System;
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
    }
}
