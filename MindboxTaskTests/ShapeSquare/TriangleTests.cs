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
    public class TriangleTests
    {
        [TestMethod()]
        public void CalcSquareTest1()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double square = triangle.CalcSquare();
            Assert.AreEqual(square, 6);
        }

        public void CalcSquareTest2()
        {
            Triangle triangle = new Triangle(3.2, 4.6, 5.9, 2);
            double square = triangle.CalcSquare();
            Assert.AreEqual(square, 7.31);
        }

        [TestMethod()]
        public void IsTriangleRightTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool isRight = triangle.IsTriangleRight();
            Assert.AreEqual(isRight, true);
        }
    }
}