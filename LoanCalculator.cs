using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    class Program
    {
        /*Написать программу - калькулятор кредита на 1 год.

        Пользователь вводит сумму, которую хочет взять в кредит, и проценты, под которые хочет взять его. Программа выдает ему список выплат за год, и в конце общую сумму (основной долг + проценты).
        
        Примерный вид интерфейса:
        ------------------------------------
        Введите сумму кредита:
        1000
        Введите проценты кредита: 
        10
        Выплаты по месяцам:
        1 месяц ... руб
        2 месяц ... руб
        ...
        12 месяц ... руб
        Общая сумма выплат составит: ... руб 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму кредита:");
            double sum;
            string stringSum = Console.ReadLine();
            double.TryParse(stringSum, out sum);
            Console.WriteLine("Введите проценты кредита:");
            double percent;
            string stringPercent = Console.ReadLine();
            double.TryParse(stringPercent, out percent);
            percent = percent / 100;
            Console.WriteLine("Выплаты по месяцам:");
            
            double paymentsPerMonth = sum / 12;
            double overall = 0;

            for (int i = 1; i <= 12; i++)
            {
                var remainder = sum - paymentsPerMonth * (i - 1);
                var monthPayment = paymentsPerMonth + remainder / 12 * percent;
                overall += monthPayment;
                Console.WriteLine($"{i} месяц {monthPayment} руб");
            }

            Console.WriteLine($"Общая сумма выплат составит: {overall} руб");
            Console.ReadKey();


        }
    }
}
