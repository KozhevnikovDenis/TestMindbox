using System.Drawing;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Mindbox
{
    public class Triangle : Figure
    {
        private double sideA, sideB, sideC, perimeter, semiPerimeter, maxSide;
        private const int digit = 1;
        
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

            if (Math.Round(this.sideA, digit) <= 0.0 || Math.Round(this.sideB, digit) <= 0.0 || Math.Round(this.sideC, digit) <= 0.0)
                throw new ArgumentOutOfRangeException("error: all sides must be > 0");

            maxSide = Math.Max(this.sideA, Math.Max(this.sideB, this.sideC));
            perimeter = this.sideA + this.sideB + this.sideC;
            
            if (Math.Round(maxSide, digit) >= Math.Round(perimeter - maxSide, digit))
                throw new ArgumentException("error: triangle not exists");
            
            semiPerimeter = perimeter / 2.0;
        }
        
        public override double GetArea() => Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        
        public bool IsRightTriangle()
        {
            if (maxSide == sideA && (Math.Round(Math.Pow(sideA, 2), digit) == Math.Round(Math.Pow(sideB, 2) + Math.Pow(sideC, 2), digit)))
                return true;
            else if (maxSide == sideB && (Math.Round(Math.Pow(sideB, 2), digit) == Math.Round(Math.Pow(sideA, 2) + Math.Pow(sideC, 2), digit)))
                return true;
            else if (maxSide == sideC && (Math.Round(Math.Pow(sideC, 2), digit) == Math.Round(Math.Pow(sideA, 2) + Math.Pow(sideB, 2), digit)))
                return true;
            else
                return false;
        }
    }
}
