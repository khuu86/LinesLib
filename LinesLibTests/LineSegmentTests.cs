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
            // Arrange: Start is smaller than end
            LineSegment smallerThanEnd = new LineSegment(1, 2);

            // Assert: Check if the start and end values are correctly assigned
            Assert.AreEqual(1, smallerThanEnd.Start);
            Assert.AreEqual(2, smallerThanEnd.End);

            // Act & Assert: Start is bigger than end, should throw an exception
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new LineSegment(2, 1));

            // Arrange: Start is equal to end
            LineSegment sameNumbers = new LineSegment(2, 2);

            // Assert: Check if the start and end values are correctly assigned
            Assert.AreEqual(2, sameNumbers.Start);
            Assert.AreEqual(2, sameNumbers.End);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            // Arrange: Create a LineSegment instance
            LineSegment toString = new LineSegment(1, 2);

            // Act & Assert: Check if ToString method returns the correct string
            Assert.AreEqual("1, 2", toString.ToString());
        }

        [TestMethod()]
        public void ContainsTest()
        {
            // Arrange: Setting LineSegment 1-5
            LineSegment lineSegment1 = new LineSegment(1, 5);

            // Act: Checking if 4 is between the lines (should be true)
            bool isContains = lineSegment1.Contains(4);

            // Assert: Check if the start and end values are contained within the segment
            Assert.IsTrue(lineSegment1.Contains(1));
            Assert.IsTrue(lineSegment1.Contains(5));

            // Arrange: Setting LineSegment 1-5
            LineSegment lineSegment2 = new LineSegment(1, 5);

            // Act: Checking if 6 is inside 1-5 (should be false)
            bool isNotContains = lineSegment2.Contains(6);

            // Assert: Check if the value is not contained within the segment
            Assert.IsFalse(isNotContains);

            // Act & Assert: Check if 0 is not contained within the segment
            Assert.IsFalse(lineSegment2.Contains(0));
        }

        [TestMethod()]
        public void Contains2Test()
        {
            // Arrange: Create two LineSegment instances
            LineSegment lineSegment1_10 = new LineSegment(1, 10);
            LineSegment lineSegment4_7 = new LineSegment(4, 7);

            // Act: Check if one segment contains the other
            bool result = lineSegment1_10.Contains(lineSegment4_7);
            bool result2 = lineSegment4_7.Contains(lineSegment1_10);

            // Assert: Verify the containment results
            Assert.IsTrue(result);
            Assert.IsFalse(result2);
        }
    }
}