using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesLib.Tests
{
    [TestClass()]
    public class LineSegmentTests
    {
        [TestMethod()]
        public void ConstructorTest()
        {
            // Arrange start is smaller than end
            LineSegment smallerThanEnd = new LineSegment(1, 2);

            // Assert
            Assert.AreEqual(1, smallerThanEnd.Start);
            Assert.AreEqual(2, smallerThanEnd.End);

            // Arrange Act & Assert start is bigger than end
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new LineSegment(2, 1));

            // Arrange start is equal to end
            LineSegment samenumbers = new LineSegment(2, 2);

            // Assert   
            Assert.AreEqual(2, samenumbers.Start);
            Assert.AreEqual(2, samenumbers.End);


        }

        [TestMethod()]

        public void ToStringTest()
        {
            // Arrange 

            LineSegment tostring = new LineSegment(1, 2);

            // Act & Assert 

            Assert.AreEqual("1, 2", tostring.ToString());
        }


        [TestMethod()]

        public void ContainsTest()
        {
            // Arrange
            LineSegment lineSegment1 = new LineSegment(1, 5);

            // Act
            bool isContanins = lineSegment1.Contains(4);

            // Assert
             // Act & Assert
            Assert.IsTrue(lineSegment1.Contains(1));
            Assert.IsTrue(lineSegment1.Contains(5));
            // Arrange
            LineSegment lineSegment2 = new LineSegment(1, 5);

            // Act
            bool isNotContains = lineSegment2.Contains(6);

            // Assert
            Assert.IsFalse(isNotContains);

            // Act & Assert
            Assert.IsFalse(lineSegment2.Contains(0));
        }


        [TestMethod()]

        public void Contains2Test()
        {
            LineSegment lineControl = new LineSegment(1,10);
        }
    }
}