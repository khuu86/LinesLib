namespace LinesLib
{
    public class LineSegment
    {
        public int Start { get; }
        public int End { get; }

        // Constructor to initialize the LineSegment with start and end values
        public LineSegment(int start, int end)
        {
            Start = start;
            End = end;

            if (start > end)
            {
                throw new ArgumentOutOfRangeException($"Start should be before end");
            }
        }

        // Override ToString() method to provide a string representation of the LineSegment
        public override string ToString()
        {
            return $"{Start}, {End}";
        }

        // Check if the LineSegment contains a point
        public bool Contains(int p)
        {
            if (Start <= p && p <= End)
            {
                return true;
            }
            return false;
        }

        // Check if the LineSegment contains another LineSegment
        public bool Contains(LineSegment anotherSegment)
        {
            if (anotherSegment.Start >= Start && anotherSegment.End <= End)
            {
                return true;
            }
            return false;
        }
    }
}
