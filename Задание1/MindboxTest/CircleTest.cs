using Mindbox;

namespace MindboxTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetAreaTest()
        {
            double radius = 10.5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Figure f = new Circle(radius);
            Assert.AreEqual(expectedArea, f.GetArea(), "error area");
        }
        [TestMethod]
        public void PositivityTest()
        {
            double radius = -10.5;
            Figure f;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => f = new Circle(radius));
        }
    }
}