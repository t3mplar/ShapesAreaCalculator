using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Ellipse : IShape
    {
        public Ellipse(double majorRadius, double minorRadius)
        {
            if (majorRadius <= 0)
                throw new ArgumentException("Большая полуось эллипса должна быть больше нуля.", nameof(majorRadius));
            if (minorRadius <= 0)
                throw new ArgumentException("Малая полуось эллипса должна быть больше нуля.", nameof(minorRadius));

            MajorRadius = majorRadius;
            MinorRadius = minorRadius;
            Area = Math.PI * MajorRadius * MinorRadius;
        }

        public double MajorRadius { get; }

        public double MinorRadius { get; }

        public double Area { get; }
    }
}
