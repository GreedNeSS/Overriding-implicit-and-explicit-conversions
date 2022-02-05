using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    struct Square
    {
        public int Length { get; set; }

        public Square(int length) : this()
        {
            Length = length;
        }

        public override string ToString() => $"[Length: {Length}]";

        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static explicit operator Square(Rectangle rectangle)
        {
            Square square = new Square
            {
                Length = rectangle.Height
            };

            return square;
        }

        public static explicit operator Square(int sideLength) =>
            new Square(sideLength);

        public static explicit operator int(Square square) =>
            square.Length;
    }
}
