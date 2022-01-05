using System;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 10;
            char symb = "*";

            int x1 = 11;
            int y1 = 10;

            Console.SetCursorPosition(x, y);
            Console.Write(symb);

            Console.SetCursorPosition(x1, y1);
            Console.Write(symb);

            Console.ReadLine();
        }
    }
}
