using Mindbox;
using System.Reflection.Metadata;

namespace MindboxTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetAreaTest()
        {
            var sideA = 10.5;
            var sideB = 10.5;
            var sideC = 10.5;
            var perimeter = sideA + sideB + sideC;
            var semiPerimeter = perimeter / 2.0;
            var expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideA) * (semiPerimeter - sideA));
            var figure = new Triangle(sideA, sideB, sideC);
            Assert.AreEqual(expectedArea, figure.GetArea(), "error: calculation area");
        }
        
        [TestMethod]
        public void IsRightTriangleTrueTest()
        {
            var sideA = 3.0;
            var sideB = 4.0;
            var sideC = 5.0;
            var expectedIsRightTriangle = true;
            var figure = new Triangle(sideA, sideB, sideC);
            Assert.AreEqual(expectedIsRightTriangle, figure.IsRightTriangle(), "error: this is right triangle");
        }

        [TestMethod]
        public void IsRightTriangleFalseTest()
        {
            var sideA = 4.0;
            var sideB = 4.0;
            var sideC = 5.0;
            var expectedIsRightTriangle = false;
            var figure = new Triangle(sideA, sideB, sideC);
            Assert.AreEqual(expectedIsRightTriangle, figure.IsRightTriangle(), "error: this is not right triangle");
        }

        [TestMethod]
        public void PositivityTest()
        {
            var sideA = -10.5;
            var sideB = -10.5;
            var sideC = -10.5;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { var figure = new Triangle(sideA, sideB, sideC); });
        }
        
        [TestMethod]
        public void ExistenceTest()
        {
            var sideA = 0.5;
            var sideB = 0.5;
            var sideC = 10.5;
            Assert.ThrowsException<ArgumentException>(() => { var figure = new Triangle(sideA, sideB, sideC); });
        }
    }
}
