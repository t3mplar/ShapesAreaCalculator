using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ShapesAreaCalculatorTests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void Create_Circle_With_Invalid_Parameters_Should_Throw_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Fact]
        public void Create_Circle_With_Valid_Parameters_Should_Calculate_Correct_Area()
        {
            const double radius = 3;
            const double expectedCircleArea = 28.274333882308138;
            
            var circle = new Circle(radius);

            Assert.Equal(expectedCircleArea, circle.Area);
        }

        [Fact]
        public void Create_Triangle_With_Invalid_Parameters_Should_Throw_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 0, 0));
        }

        [Fact]
        public void Create_Triangle_With_Valid_Parameters_Should_Calculate_Correct_Area()
        {
            const double sideA = 3;
            const double sideB = 5;
            const double sideC = 7;
            const double expectedTriangleArea = 6.49519052838329;

            var triangle = new Triangle(sideA, sideB, sideC);

            Assert.Equal(expectedTriangleArea, triangle.Area);
        }

        [Fact]
        public void Create_Triangle_With_Sides_Forming_Right_Triangle_Should_Confirm_It()
        {
            const double sideA = 3;
            const double sideB = 4;
            const double sideC = 5;
            const bool expectedTriangleIsRight = true;

            var triangle = new Triangle(sideA, sideB, sideC);

            Assert.Equal(expectedTriangleIsRight, triangle.IsRight());
        }

        [Fact]
        public void Create_Triangle_With_Sides_Not_Forming_Right_Triangle_Should_Confirm_It()
        {
            const double sideA = 3;
            const double sideB = 3;
            const double sideC = 5;
            const bool expectedTriangleIsRight = false;

            var triangle = new Triangle(sideA, sideB, sideC);

            Assert.Equal(expectedTriangleIsRight, triangle.IsRight());
        }

        // Не уверен, что понял правильно задание с вычислением площади фигур без знания типов этих фигур, но, бу
        [Fact]
        public void Given_List_Of_Shapes_Without_Certain_Type_Should_Return_Their_Areas()
        {
            const double radius = 3;
            var circle = new Circle(radius);

            const double sideA = 3;
            const double sideB = 5;
            const double sideC = 7;
            var triangle = new Triangle(sideA, sideB, sideC);

            var listOfShapes = new List<IShape> { circle, triangle };
            var listOfSpaeAreas = listOfShapes.Select(s => s.Area);
            var expectedListOfAreas = new[] { 28.274333882308138, 6.49519052838329 };

            Assert.Equal(expectedListOfAreas, listOfSpaeAreas);
        }
    }
}
