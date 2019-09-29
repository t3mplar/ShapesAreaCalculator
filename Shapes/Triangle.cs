using System;
using System.Collections.Generic;

namespace Shapes
{
    public class Triangle : IShape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
                throw new ArgumentException("Сторона треугольника должна быть больше нуля.", nameof(sideA));
            if (sideB <= 0)
                throw new ArgumentException("Сторона треугольника должна быть больше нуля.", nameof(sideB));
            if (sideC <= 0)
                throw new ArgumentException("Сторона треугольника должна быть больше нуля.", nameof(SideC));

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            var p = 0.5 * (SideA + SideB + SideC);
            Area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        
        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        public double Area { get; }

        public bool IsRight()
        {
            // Можно наверное сделать вариант в котором последовательно подставлять в качестве гипотенузы
            // каждую из сторон, но мне кажется, что мой вариант более понятный.
            var sidesOrderedByLength = new List<double> { SideA, SideB, SideC };
            sidesOrderedByLength.Sort();

            var hypotenuse = sidesOrderedByLength[2];
            var side1 = sidesOrderedByLength[0];
            var side2 = sidesOrderedByLength[1];

            return Math.Pow(hypotenuse, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2); 
        }
    }
}
