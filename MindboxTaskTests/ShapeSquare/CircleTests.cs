using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTask.ShapeSquare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask.ShapeSquare.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CalcSquareTest1()
        {
            Circle circle = new Circle(1);
            double square = circle.CalcSquare();
            Assert.AreEqual(square, Math.Round(Math.PI * 1 * 1), 2);
        }

        [TestMethod()]
        public void CalcSquareTest2()
        {
            Circle circle = new Circle(1, 1);
            double square = circle.CalcSquare();
            Assert.AreEqual(square, Math.Round(Math.PI * 1 * 1), 1);
        }
    }
}