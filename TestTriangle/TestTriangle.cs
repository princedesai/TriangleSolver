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
                //Arrange
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;
                string expected = "Equilateral triangle";
                //Act
                string actual=Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForValidIsoscelesTriangle_Input5and4and5_OutputIsoscelestriangle()
            {
                //Arrange
                int firstSide = 5;
                int secondSide = 4;
                int thirdSide = 5;
                string expected = "Isosceles triangle";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForValidIsoscelesTriangle_Input5and5and7_OutputIsoscelestriangle()
            {
                //Arrange
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 7;
                string expected = "Isosceles triangle";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForValidIsoscelesTriangle_Input3and5and5_OutputIsoscelestriangle()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 5;
                int thirdSide = 5;
                string expected = "Isosceles triangle";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForValidScalene_Input3and4and5_OutputScalene()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 5;
                string expected = "Scalene triangle";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForValidScalene_Input7and10and12_OutputScalene()
            {
                //Arrange
                int firstSide = 7;
                int secondSide = 10;
                int thirdSide = 12;
                string expected = "Scalene triangle";
                //Act
                string actual=Triangle.AnalyzeTriangle(firstSide,secondSide, thirdSide);
                //Assert
                Assert.That(actual,Is.EqualTo(expected));
            }
            [Test]
            public void checkForScalene_Input5and9and13_OutputScalene()
            {
                //Arrange
                int firstSide = 5;
                int secondSide = 9;
                int thirdSide = 13;
                string expected = "Scalene triangle";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual , Is.EqualTo(expected));
            }
            [Test]
            public void checkForScalene_Input6and8and10_OutputScalene()
            {
                //Arrange
                int firstSide = 6;
                int secondSide = 8;
                int thirdSide = 10;
                string expected = "Scalene triangle";
                //Act
                string actual=Triangle.AnalyzeTriangle(firstSide,secondSide,thirdSide);
                //Assert
                Assert.That (actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForScalene_Input15and20and25_OutputScalene()
            {
                //Arrange
                int firstSide = 15;
                int secondSide = 20;
                int thirdSide = 25;
                string expected = "Scalene triangle";
                //Act
                string actual=Triangle.AnalyzeTriangle(firstSide,secondSide, thirdSide);
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForZeroLengthOneSide_Input0and20and25_OutputInvalidTriangleAZeroHasBeenDetected()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 20;
                int thirdSide = 25;
                string expected = "Invalid Triangle - a zero has been detected";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForZeroLengthTwoSide_Input0and0and4_OutputInvalidTriangleAZeroHasBeenDetected()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 4;
                string expected = "Invalid Triangle - a zero has been detected";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual,Is.EqualTo(expected));
            }
            [Test]
            public void checkForZeroLengthSideThree_Input3and4and0_OutputInvalidTriangleAZeroHasBeenDetected()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 0;
                string expected = "Invalid Triangle - a zero has been detected";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForInvalidTriangle_Input3and4and10_OutputInvalid()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 10;
                string expected = "INVALID!!";
                //Act
                string actual=Triangle.AnalyzeTriangle(firstSide,secondSide, thirdSide);
                //Assert
                Assert.That(actual , Is.EqualTo(expected));
            }
            [Test]
            public void checkForInvalidTriangle_Input5and20and520_OutputInvalid()
            {
                //Arrange
                int firstSide = 2;
                int secondSide = 7;
                int thirdSide = 27;
                string expected = "INVALID!!";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
            [Test]
            public void checkForInvalidTriangle_Input7and2and12_OutputInvalid()
            {
                //Arrange
                int firstSide = 7;
                int secondSide = 2;
                int thirdSide = 12;
                string expected = "INVALID!!";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

        }

    }
}
