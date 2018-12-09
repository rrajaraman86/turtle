using System;
namespace turtle
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            Point p = (Point)obj;
            return p.x == this.x && p.y == this.y;
        }
    }
}
