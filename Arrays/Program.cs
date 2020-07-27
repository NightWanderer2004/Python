using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Group = { 500, 240, 320, 400, 145 }; 

            Console.Write("First:" + Group[0] + "  ===");

            if(Group[0] >= 500)
            {
                Console.WriteLine("\tВсё Ок\n");
            }
            else
            {
                Console.WriteLine("\tНе Ок\n");
            }

            Console.Write("Second:" + Group[1] + "  ===");

            if(Group[1] >= 300)
            {
                Console.WriteLine("\tВсё Ок\n");
            }
            else
            {
                Console.WriteLine("\tНе Ок\n");
            }

            Console.Write("Third:" + Group[2] + "  ===");

            if(Group[2] >= 320)
            {
                Console.WriteLine("\tВсё Ок\n");
            }
            else
            {
                Console.WriteLine("\tНе Ок\n");
            }

            Console.Write("Fourth:" + Group[3] + "  ===");

            if(Group[3] >= 400)
            {
                Console.WriteLine("\tВсё Ок\n");
            }
            else
            {
                Console.WriteLine("\tНе Ок\n");
            }

            Console.Write("Fifth:" + Group[4] + "  ===");

            if (Group[4] >= 340)
            {
                Console.WriteLine("\tВсё Ок\n");
            }
            else
            {
                Console.WriteLine("\tНе Ок\n");
            }

            Console.ReadLine();
        }
    }
}
