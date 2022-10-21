namespace JobTask.UnitTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Square_5_Return78_5()
        {
            //Arrange
            var circle = new Circle(5);
            double expected = 78.5;

            //Act
            var result = circle.Square();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class TriangleTest 
    {
        [TestMethod]
        public void Square_3and4and5_Return6() 
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);
            double expecred = 6;

            //Act
            var result = triangle.Square();

            //Assert
            Assert.AreEqual(expecred, result);
        }

        [TestMethod]
        public void isStraightTriangle_2and3and4_ReturnFalse() 
        {
            //Arrange
            var triangle = new Triangle(2, 3, 4);

            //Act
            var result = triangle.isStraightTriangle();

            //Assert
            Assert.IsFalse(result);
        }
    }
}