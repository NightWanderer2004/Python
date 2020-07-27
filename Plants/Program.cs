using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание массива
            float[] Plants = new float[5];
            //Запрос данных
            for (int i = 0; i < Plants.Length; i++)
            {
                Console.Write($"|Цветок номер {i + 1} : ");
                Plants[i] = float.Parse(Console.ReadLine());
            }
            //Поиск минимального значение
            float MinPlant = Plants[0];

            for (int i = 1; i < Plants.Length; i++)
            {
                if (Plants[i] < MinPlant)
                {
                    MinPlant = Plants[i];
                }
            }
            //Результат
            if (Plants[0] >= 15)
            {
                Console.WriteLine($"\nЦветок {1} : OK");
            }
            else
            {
                Console.WriteLine($"\nЦветок {1} : HE OK");
            }

            if (Plants[1] >= 15)
            {
                Console.WriteLine($"\nЦветок {2} : OK");
            }
            else
            {
                Console.WriteLine($"\nЦветок {2} : HE OK");
            }

            if (Plants[2] >= 15)
            {
                Console.WriteLine($"\nЦветок {3} : OK");
            }
            else
            {
                Console.WriteLine($"\nЦветок {3} : HE OK");
            }

            if (Plants[3] >= 15)
            {
                Console.WriteLine($"\nЦветок {4} : OK");
            }
            else
            {
                Console.WriteLine($"\nЦветок {4} : HE OK");
            }

            if (Plants[4] >= 15)
            {
                Console.WriteLine($"\nЦветок {5} : OK");
            }
            else
            {
                Console.WriteLine($"\nЦветок {5} : HE OK");
            }
            //Вывод минимального значения
            Console.WriteLine("\nМинимальное расстение = " + MinPlant + " CM");

            Console.ReadLine();
        }
    }
}
