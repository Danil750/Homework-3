using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    /* Задача 1.
     Написать алгоритм, рассчитывающий площадь круга по заданному радиусу.
     Примерный вид интерфейса:
     ------------------------------------
     Введите радиус круга:
     Площадь круга: ...*/

    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите радиус круга: ");
            const double pi = 3.14;
            string rString = Console.ReadLine();
            double r;
            double.TryParse(rString, out r);
            Console.Write("Площадь круга: " + (pi * r * r));
            Console.ReadKey();

        }
    }
}
