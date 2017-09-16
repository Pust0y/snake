using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char syn1 = '*';

            Drow( x1, y1, syn1 );

            int x2 = 4;
            int y2 = 5;
            char syn2 = '#';

            Drow( x2, y2, syn2 );

            Console.ReadLine();

        }

        static void Drow(int x, int y, char syn)
        {
            Console.SetCursorPosition( x, y);
            Console.WriteLine( syn );
        }
    }
}
