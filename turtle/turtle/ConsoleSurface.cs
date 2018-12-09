using System;
namespace turtle
{
    public class ConsoleSurface: ISurface
    {
        public ConsoleSurface()
        {
            
        }

		public void DrawAt(Point point, char c)
        {
            Console.SetCursorPosition(point.x, point.y);
            Console.Write(c);
        }
    }
}
