using System;

namespace Shapes
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус окружности должен быть больше нуля.", nameof(radius));

            Radius = radius;
            Area = Math.PI * Radius * Radius;
        }

        public double Radius { get; }

        public double Area { get; }
    }
}
