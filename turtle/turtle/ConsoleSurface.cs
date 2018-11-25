using System;
namespace turtle
{
    public class ConsoleSurface: ISurface
    {
        ILineWriter lw;
        public ConsoleSurface(ILineWriter lineWriter)
        {
            this.lw = lineWriter;
        }

        public void DrawAt(Point point)
        {
            lw.Put(".");
        }
    }
}
