using NUnit.Framework;
using TriangleApplication;

namespace TriangleTests
{
   
    [TestFixture]
    public class UnitTest
    {

        string triangle;

        [Test]
        public void Equilateral_Threesides_Four() // Verify three euqal sides for an equilateral triangle with value 4
        {
            int a = 4, b = 4, c = 4;
            triangle = "Equilateral";
            Assert.AreEqual(triangle, TriangleSolver.analyze(a, b, c));
        }

        [Test]
        public void Equilateral_ThreeSides_Eight() // Verify three euqal sides for an equilateral triangle with value 8
        {
            int a = 8, b = 8, c = 8;
            triangle = "Equilateral";
            Assert.AreEqual(triangle, TriangleSolver.analyze(a, b, c));
        }

        [Test]
        public void Isocelues_sideA_and_SideB_Seven() // Verify any two sides are equal for an isoceles triangle -- here A and B are equal
        {
            int a = 7, b = 7, c = 6;
            triangle = "Isosceles";
            Assert.AreEqual(triangle, TriangleSolver.analyze(a, b, c));
        }

        [Test]
        public void Isocseles_sideA_and_SideC_Five() // Verify that  any two sides are equal for an isoceles triangle -- here A and C are equal
        {
            int a = 6, b = 10, c = 6;
            triangle = "Isosceles";
            Assert.AreEqual(triangle, TriangleSolver.analyze(a, b, c));
        }

        [Test]
        public void Isosceles_sideB_and_SideC_Eight() // Verify that  any two sides are equal for an isoceles triangle -- here B and C are equal
        {
            int a = 10, b = 9, c = 9;
            triangle = "Isosceles";
            Assert.AreEqual(triangle, TriangleSolver.analyze(a, b, c));
        }

        [Test]
        public void Scalene_Four_Seven_Eight() // Verify that three different vaules makes a scalene triangle -- 4,7,8
        {
            int a = 4, b = 7, c = 8;
            triangle = "Scalene";
            Assert.AreEqual(triangle, TriangleSolver.analyze(a, b, c));
        }

        [Test]
        public void Scalene_Five_Ten_Fifteen() // Verify that three different vaules makes a scalene triangle -- 5,10,15
        {
            int a = 5, b = 10, c = 15;
            triangle = "Scalene";
            Assert.AreEqual(triangle, TriangleSolver.analyze(a, b, c));
        }

        [Test]
        public void Scalene_Seven_Forteen_TwentyOne() // Verifychecks for three different vaules makes a scalene triangle -- 7,14,21
        {
            int a = 7, b = 14, c = 21;
            triangle = "Scalene";
            Assert.AreEqual(triangle, TriangleSolver.analyze(a, b, c));
        }
    }
}