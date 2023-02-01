using System.Drawing;
using System.Reflection.Metadata;

namespace Mindbox
{
    public class Triangle : Figure
    {
        private double sideA, sideB, sideC, perimeter, maxSide;
        public Triangle(double sideA, double sideB, double sideC)
        {
            perimeter = sideA + sideB + sideC;
            maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
            if (sideA <= 0.0 || sideB <= 0.0 || sideC <= 0.0)
                throw new ArgumentOutOfRangeException("error: all sides must be > 0");
            if (maxSide >= perimeter - maxSide)
                throw new ArgumentException("error: triangle not exists");
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            if      (maxSide == sideA && (Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2)))
                Console.WriteLine("right triangle");
            else if (maxSide == sideB && (Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2)))
                Console.WriteLine("right triangle");
            else if (maxSide == sideC && (Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2)))
                Console.WriteLine("right triangle");
            else
                Console.WriteLine("not right triangle");
        }
        public override double GetArea() => Math.Sqrt(0.5 * perimeter * (0.5 * perimeter - sideA) * (0.5 * perimeter - sideB) * (0.5 * perimeter - sideC));
    }
}
