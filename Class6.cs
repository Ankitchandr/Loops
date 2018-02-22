using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppControlStament
{
    class Class6
    {
        static void Main(string[] args)
        {
            int i = 0;
            int s = 0;
            while (i <= 10)
            {
                s = s + i;
                Console.WriteLine("i = " + i);
                i++;

            }
            Console.WriteLine("Sum = " + s);
            Console.Read();
        }
    }
}
