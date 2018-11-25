using System;
namespace turtle
{
    public class LineWriter: ILineWriter
    {
        public LineWriter()
        {
        }

        public void Put(string s)
        {
            Console.Write(s);
        }
    }
}
