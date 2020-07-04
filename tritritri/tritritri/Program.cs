using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tritritri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers:");
            int height = int.Parse(Console.ReadLine());
            while (true)
            {
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i <= j; i++)
                    {
                        Console.Write(" ");
                    }
                    for (int i = height; i > j; i--)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                for (int x = 0; x < height; x++)
                {
                    for (int z = 0; z <= x; z++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
