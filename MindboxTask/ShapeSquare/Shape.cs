using System;

namespace MindboxTask.ShapeSquare
{
    public abstract class Shape
    {
        public string ShapeType { get; set; }

        public abstract double CalcSquare();
    }
}
