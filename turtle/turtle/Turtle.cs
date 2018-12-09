using System;
namespace turtle
{
    public class Turtle
    {
        public bool canYouSeeMe;

        public char headOfTurtle = '>';
		public char trail = '-';

		public Point position;

        private ISurface _surface;
        private Direction _direction;

        public Turtle()
        {
            canYouSeeMe = true;
            _direction = Direction.Right;
        }

        public Turtle(ISurface surface): this()
		{
            _surface = surface;
		}

        public void Draw(ISurface surface)
        {
            
            surface.DrawAt(this.position, headOfTurtle);
        }

		public void DrawTail(ISurface surface)
		{

			surface.DrawAt(this.position, trail);
		}

        public void Move(Direction direction, ISurface surface)
        {
            DrawTail(surface);

            if (Direction.Right == direction)
                this.position.x++;

            Draw(surface);
        }

		public void Move()
		{
            Move(_direction, _surface);
		}
    }
}
