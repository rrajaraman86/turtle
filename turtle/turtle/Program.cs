using System;

namespace turtle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Turtle turtle = new Turtle();
            ILineWriter lw = new LineWriter();
            ISurface surface = new ConsoleSurface(lw);
            turtle.Draw(surface);
        }
    }
}
