using System;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r);
            r.Draw();

            Console.WriteLine();

            Square s = (Square)r;
            Console.WriteLine(s);
            s.Draw();

            Console.WriteLine();

            Rectangle newR = s;
            Console.WriteLine($"newR: {newR}");
            newR.Draw();

            Console.WriteLine();

            Square s2 = (Square)6;
            Console.WriteLine($"(Square)100: {s2}");
            s2.Draw();

            Console.WriteLine();

            Console.WriteLine($"(int)s2: {(int)s2}");
        }
    }
}
