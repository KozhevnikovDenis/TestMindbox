using Mindbox;

namespace MindboxTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetAreaTest()
        {
            var radius = 10.5;
            var expectedArea = Math.PI * Math.Pow(radius, 2);
            var figure = new Circle(radius);
            Assert.AreEqual(expectedArea, figure.GetArea(), "error: calculation area");
        }
        [TestMethod]
        public void PositivityTest()
        {
            var radius = -10.5;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { var figure = new Circle(radius); });
        }
    }
}