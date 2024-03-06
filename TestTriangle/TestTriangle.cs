using NUnit.Framework;
using TriangleSolver;

namespace TestTriangle
{
    public class TestTriangle
    {
        [TestFixture]
        public class Testing
        {
            [Test]
            public void checkForEquailateralTriangleInput5and5and5OutputEquilateraltriangle()
            {
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;
                string expected = "Equilateral triangle";
                string actual=Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

    }
}
