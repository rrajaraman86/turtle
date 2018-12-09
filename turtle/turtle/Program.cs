using System;

namespace turtle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ISurface surface = new ConsoleSurface();
            Turtle turtle = new Turtle(surface);
            turtle.position = new Point(2, 3);

            Camera camera = new Camera();
            camera.MovementsPerSecond = 3;

            int unitsOfMovement = 30;

            camera.Record(turtle, unitsOfMovement);
		}
    }
}
