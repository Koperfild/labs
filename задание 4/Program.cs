using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            uint number;

            if (!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка при вводе числа.Нажмите Enter для выхода");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Random rand = new Random();
            int[] rarray = new int[number];

            DateTime timestart = DateTime.Now;
            
            for (int i = 0; i < number; i++)
            {
                rarray[i] = rand.Next(-2147483648, 2147483647);
            }
            DateTime timefinish = DateTime.Now;

            double alltime = (timefinish.Ticks - timestart.Ticks) * 1E-7;
            
            if (alltime > 5) { Console.WriteLine("Превышено допустимое время работы программы, введите количество поменьше"); }
            if (alltime < 1E-7) { Console.WriteLine("Генерация заняла меньше наносекунды"); }
            else
            {
                Console.WriteLine("Генерация заняла примерно " + alltime + " секунд");
            }
            Console.WriteLine("Нажмите Enter для вывода чисел на экран");
            Console.ReadKey();

            for (int i = 0; i < number; i++)
            {
              
                Console.Write(rarray[i]+", ");
            }
           Console.WriteLine("Все числа выведены");
           Console.ReadLine();
        }
    }
}
