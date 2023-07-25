using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immidart
{
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing square...");
        }
    }
    public class triangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing triangle...");
        }
    }
    public class TestAbstract
    {
        public static void Main()
        {
            Shape s;
            s = new square();
            s.draw();
            s = new triangle();
            s.draw();
        }
    }
}
/*
drawing square...
drawing triangle...
*/
