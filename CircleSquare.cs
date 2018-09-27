using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /*Написать алгоритм, рассчитывающий площадь круга по заданному радиусу.
        Примерный вид интерфейса:
        ----------------------------------—
        Введите радиус круга:
        Площадь круга: ...*/

        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга: ");
            string r = Console.ReadLine();
            int radius;
            
            if (int.TryParse(r, out radius))
            {
                //S = pi * r * r
                Console.WriteLine("Площадь круга: " + radius * radius + "pi");
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
            
            Console.ReadKey();
        }
    }
}
