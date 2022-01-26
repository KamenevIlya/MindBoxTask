using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask.ShapeSquare
{
    public class Circle:Shape
    {
        private readonly double _radius;
        private readonly int _precision = 2;

        public Circle(double radius)
        {
            _radius = radius;
            ShapeType = "Circle";
        }

        public Circle(double radius, int precision):this(radius)
        {
            _precision = precision;
        }

        public override double CalcSquare()
        {
            return Math.Round(Math.PI*_radius*_radius, _precision);
        }
    }
}
