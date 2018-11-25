using System;
namespace turtle
{
    public class Turtle
    {
        public bool canYouSeeMe;

        public Point position;

        public Turtle()
        {
            canYouSeeMe = true;
        }

        public void Draw(ISurface surface)
        {
            
            surface.DrawAt(this.position);
        }
    }
}
