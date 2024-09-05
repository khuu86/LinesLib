namespace LinesLib
{
    public class LineSegment
    {
        public int Start { get; }
        public int End { get; }



        public LineSegment(int start, int end)
        {
            Start = start;
            End = end;

            if (start > end)
            {
                throw new ArgumentOutOfRangeException($"Start should be before end");
            }
        }

        public override string ToString()
        {
            return $"{Start}, {End}";
        }

        public bool Contains(int p)
        {

            if (Start <= p && p <= End)
            {
                return true;
            }
            return false;
        }

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
