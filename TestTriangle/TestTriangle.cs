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
            public void checkForValidEquailateralTriangle_Input5and5and5_OutputEquilateraltriangle()
            {
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;
                string expected = "Equilateral triangle";
                string actual=Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForValidIsoscelesTriangle_Input5and4and5_OutputIsoscelestriangle()
            {
                int firstSide = 5;
                int secondSide = 4;
                int thirdSide = 5;
                string expected = "Isosceles triangle";
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForValidIsoscelesTriangle_Input5and5and7_OutputIsoscelestriangle()
            {
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 7;
                string expected = "Isosceles triangle";
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForValidIsoscelesTriangle_Input3and5and5_OutputIsoscelestriangle()
            {
                int firstSide = 3;
                int secondSide = 5;
                int thirdSide = 5;
                string expected = "Isosceles triangle";
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForValidScalene_Input3and4and5_OutputScalene()
            {
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 5;
                string expected = "Scalene triangle";
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForValidScalene_Input7and10and12_OutputScalene()
            {
                int firstSide = 7;
                int secondSide = 10;
                int thirdSide = 12;
                string expected = "Scalene triangle";
                string actual=Triangle.AnalyzeTriangle(firstSide,secondSide, thirdSide);
                Assert.That(actual,Is.EqualTo(expected));
            }
            [Test]
            public void checkForScalene_Input5and9and13_OutputScalene()
            {
                int firstSide = 5;
                int secondSide = 9;
                int thirdSide = 13;
                string expected = "Scalene triangle";
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                Assert.That(actual , Is.EqualTo(expected));
            }
            [Test]
            public void checkForScalene_Input6and8and10_OutputScalene()
            {
                int firstSide = 6;
                int secondSide = 8;
                int thirdSide = 10;
                string expected = "Scalene triangle";
                string actual=Triangle.AnalyzeTriangle(firstSide,secondSide,thirdSide);
                Assert.That (actual, Is.EqualTo(expected));
            }
            public void checkForScalene_Input15and20and25_OutputScalene()
            {
                int firstSide = 15;
                int secondSide = 20;
                int thirdSide = 25;
                string expected = "Scalene triangle";
                string actual=Triangle.AnalyzeTriangle(firstSide,secondSide, thirdSide);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

    }
}
