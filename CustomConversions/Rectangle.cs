using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    struct Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int width, int height) : this()
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override string ToString() => $"[Width = {Width}, Height = {Height}";

        public static implicit operator Rectangle(Square square) =>
            new Rectangle(square.Length * 2, square.Length);
    }
}
