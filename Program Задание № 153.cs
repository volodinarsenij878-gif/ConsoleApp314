using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program153
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Номер месяца (1–12): ");
            if (!int.TryParse(Console.ReadLine(), out int m))
            {
                Console.WriteLine("Ошибка: введите целое число.");
                return;
            }

            string[] months = new string[13]
            {
            "", "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };

            if (m >= 1 && m <= 12)
                Console.WriteLine(months[m]);
            else
                Console.WriteLine("Некорректный месяц.");
        }
    }
}