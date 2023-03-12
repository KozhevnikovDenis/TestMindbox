namespace Mindbox
{
    public class Circle : Figure
    {
        private double radius;
        private const int digit = 1;
        public Circle(double radius)
        {
            this.radius = radius;

            if (Math.Round(this.radius, digit) <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(this.radius), "error: radius must be > 0");
        }
        public override double GetArea() => Math.PI * Math.Pow(radius, 2);
    }
}
