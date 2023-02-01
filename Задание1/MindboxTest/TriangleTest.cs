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
            double sideA = 10.5;
            double sideB = 10.5;
            double sideC = 10.5;
            double perimeter = sideA + sideB + sideC;
            double expectedArea = Math.Sqrt(0.5 * perimeter * (0.5 * perimeter - sideA) * (0.5 * perimeter - sideA) * (0.5 * perimeter - sideA));
            Figure f = new Triangle(sideA, sideB, sideC);
            Assert.AreEqual(expectedArea, f.GetArea(), "error area");
        }
        [TestMethod]
        public void PositivityTest()
        {
            double sideA = -10.5;
            double sideB = -10.5;
            double sideC = -10.5;
            Figure f;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => f = new Triangle(sideA, sideB, sideC));
        }
        [TestMethod]
        public void ExistenceTest()
        {
            double sideA = 0.5;
            double sideB = 0.5;
            double sideC = 10.5;
            Figure f;
            Assert.ThrowsException<ArgumentException>(() => f = new Triangle(sideA, sideB, sideC));
        }
    }
}
