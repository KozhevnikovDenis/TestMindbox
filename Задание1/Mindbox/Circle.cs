namespace Mindbox
{
    public class Circle : Figure
    {
        private double radius;
        public Circle(double radius)
        {
            if (radius <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(radius), "error: radius must be > 0");
            this.radius = radius;
        }
        public override double GetArea() => Math.PI * Math.Pow(radius, 2);
    }
}
