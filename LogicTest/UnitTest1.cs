using NUnit.Framework;
using ChessLogic;
using System.Drawing;

namespace LogicTest
{
   public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestKnightIncorrectStep()
        {
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(5, 7))));
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(5, 5))));
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(5, 6))));
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(6, 6))));
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(7, 7))));
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(0, 0))));
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(0, 0), new Point(0, 0))));
        }
        
        [Test]
        public void TestKnightCorrectStep()
        {
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(6, 7))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(6, 3))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(4, 7))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(4, 3))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(3, 4))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(3, 6))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(7, 4))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Knight", new Vector(new Point(5, 5), new Point(7, 6))));
        }
        
        [Test]
        public void TestKingIncorrectStep()
        {
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("King", new Vector(new Point(0, 0), new Point(0, 0))));
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("King", new Vector(new Point(0, 0), new Point(1, 1))));
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("King", new Vector(new Point(0, 0), new Point(10, 10))));
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("King", new Vector(new Point(0, 0), new Point(10, 10))));
        }
        
        [Test]
        public void TestKingCorrectStep()
        {
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("King", new Vector(new Point(4, 1), new Point(4, 2))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("King", new Vector(new Point(4, 1), new Point(4, 2))));
        }
        
        [Test]
        public void TestBishopCorrectStep()
        {
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Bishop", new Vector(new Point(1, 1), new Point(5, 5))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Bishop", new Vector(new Point(5, 5), new Point(7, 7))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Bishop", new Vector(new Point(5, 5), new Point(2, 2))));
            Assert.AreEqual(true, FigureEngine.IsCorrectStep("Bishop", new Vector(new Point(6, 2), new Point(8, 4))));
        }
        
        [Test]
        public void TestBishopIncorrectStep()
        {
            Assert.AreEqual(false, FigureEngine.IsCorrectStep("Bishop", new Vector(new Point(1, 1), new Point(1, 2))));
        }
    }
}