using System;
using System.Threading;

namespace turtle
{
    public class Camera
    {
        public int MovementsPerSecond;

        public Camera()
        {
            MovementsPerSecond = 10;
        }

        public void Record(Turtle turtle, int unitsOfMovement)
        {
            while(unitsOfMovement > 0)
            {
                turtle.Move();
                unitsOfMovement--;

                //delay
                Thread.Sleep((int) ((1.0 / MovementsPerSecond) * 1000));
            }

        }
    }
}
