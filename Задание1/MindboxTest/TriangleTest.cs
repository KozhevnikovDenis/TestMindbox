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
            var expectedArea = Math.Sqrt(0.5 * perimeter * (0.5 * perimeter - sideA) * (0.5 * perimeter - sideA) * (0.5 * perimeter - sideA));
            var figure = new Triangle(sideA, sideB, sideC);
            Assert.AreEqual(expectedArea, figure.GetArea(), "error area");
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
