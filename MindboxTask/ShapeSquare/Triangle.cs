using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask.ShapeSquare
{
    public class Triangle:Shape
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;
        private readonly int _precision=1;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (IsSidesPositive(firstSide, secondSide, thirdSide))
            {
                _firstSide = firstSide;
                _secondSide = secondSide;
                _thirdSide = thirdSide;
                ShapeType = "Triangle";
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide, int precision) :this(firstSide,secondSide,thirdSide)
        {
            _precision = precision;
        }

        public override double CalcSquare()
        {
            double halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            return Math.Round(Math.Sqrt(halfPerimeter*(halfPerimeter-_firstSide)*(halfPerimeter-_secondSide)*(halfPerimeter-_thirdSide)), _precision);
        }

        private bool IsSidesPositive(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide > 0 && secondSide > 0 && thirdSide > 0;
        }
        
        public bool IsTriangleRight()
        {
            if (_firstSide > _secondSide)
            {
                if (_firstSide > _thirdSide)
                {
                    return Math.Abs(_firstSide-Math.Sqrt(_secondSide*_secondSide+_thirdSide*_thirdSide)) <= 1 / Math.Pow(10, _precision);
                }
                else
                {
                    return Math.Abs(_thirdSide - Math.Sqrt(_secondSide * _secondSide + _firstSide * _firstSide)) <= 1 / Math.Pow(10, _precision);
                }
            }
            else if (_secondSide > _thirdSide)
            {
                return Math.Abs(_secondSide - Math.Sqrt(_firstSide * _firstSide + _thirdSide * _thirdSide)) <= 1 / Math.Pow(10, _precision);
            }
            return Math.Abs(_thirdSide - Math.Sqrt(_secondSide * _secondSide + _firstSide * _firstSide)) <= 1 / Math.Pow(10, _precision);
        }
    }
}
