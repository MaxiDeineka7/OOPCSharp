using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // проста програма
            /*
             * rkgkrjg
             * grg
             * rg
             * grgr
             */

            //тип_даних ім'я змінної;
            int value;

            // назва змінної - починається з літери або _
            // може містити будь-які символи, цифри та знак _
            //string address;
            //int value;
            //int Value = 10;
            //int myFirstValue;
            //value = 5;
            //Value = 5;
            //Console.WriteLine(value);

            //bool a1 = (3 < 6) ^ (4<8); 

            //int a = 5;
            //int b = 10;
            //int result = a / b;
            //Console.WriteLine($"gg: {result}");

            //byte x = 2;
            //byte y = 2;
            //bool h = x >= y;

            //bool l = !h;

            //Конвертація
            //int number = Convert.ToInt32(Console.ReadLine());
            //float number2 = float.Parse(Console.ReadLine());


            //double a = 9;
            //double b = 2;
            //a += 5; //=  a = a + 5
            //a--;

            //Console.WriteLine(Math.Sqrt(a)); //корінь
            //Console.WriteLine(Math.Pow(a, b)); // до степеня
            //Console.WriteLine(Math.Abs(a)); // модуль

            //double c = 9.23;
            //Console.WriteLine(Math.Round(c)); // округлення
            //Console.WriteLine(Math.Floor(c)); // округлення до меншого
            //Console.WriteLine(Math.Ceiling(c)); // округлення до більшого

            //Math.Min(a, b);
            //Math.Max(a, b);

            //Console.WriteLine($"gg:");

            //Random rnd  = new Random();
            //int rndNumb = rnd.Next(1,11);

            //Console.WriteLine("Улюблене число:");

            //Console.WriteLine("Твоє число 1: " + number);
            //Console.WriteLine("Твоє число 2: {0}, {1}", number, number);
            //Console.WriteLine($"Твоє число 3: {number}");
            Console.WriteLine($"Перше число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Друге число");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b | a < b)
                Console.WriteLine("Число більше!");
            else if (a == b)
            {
                Console.WriteLine("Вони рівні!!!");
            }
            else
            {
                Console.WriteLine("Число менше!");
            }

            //Console.WriteLine($"число");
            //int b = Convert.ToInt32(Console.ReadLine());

            //switch (b) { 
            //    case 0:
            //        Console.WriteLine("Це 0!");
            //        break;
            //    case 1:
            //        Console.WriteLine("Це 1!");
            //        break;
            //    default: Console.WriteLine("Не то!");
            //        break;
            //}

            //Console.ReadLine();

        }
    }
}
