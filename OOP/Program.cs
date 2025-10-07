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
            //////FOR
            for (int r = 0; r < 100; r++)
            {
                Console.WriteLine(r);
            }

            // ВКЛАДЕНИЙ ЦИКЛ FOR
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine($"{x} * {y} = {x * y}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            // WHILE
            int i = 5;
            while (i <= 4)
            {
                Console.WriteLine("WHILE: " + i);
                i++;
            }

            // DO WHILE
            do
            {
                Console.WriteLine("DO WHILE: " + i);
            } while (i < 4);

            Console.ReadLine();


            // FOREACH
            string[] names = { "Maksym", "Andrew", "Tamara", "Igor" };

            foreach (string name in names)
            {
                Console.WriteLine("Здоров! " + name);
            }

            Console.ReadLine();

            //КЕРУВАННЯ ВИКОНАННЯМ ЦИКЛУ
            for (int t = 0; t < 10; t++)
            {
                if (t == 2) { continue; }
                if (t % 2 == 0) { continue; }
                if (t == 7) { break; }

                Console.WriteLine(i);
            }

            Console.ReadLine();

            //MAСИВИ

            //оголошення пустого масиву з 10 елементів
            int[] numbers = new int[10];
            //Console.WriteLine(numbers[0]);

            //оголошення масиву з 5 елементів
            int[] numbers2 = new int[] { 3, 4, 3, 4, 0 };
            //Console.WriteLine(numbers2[0]);

            //перебір масиву з FOR
            for (int w = 0; w < numbers2.Length; w++)
            {
                Console.WriteLine(Convert.ToString(numbers2[w])); // 3,4,3,4,0
            }

            Console.ReadLine();

            //перебір масиву з FOREACH
            foreach (int number in numbers2)
            {
                Console.WriteLine(Convert.ToString(number));
            }
            Console.ReadLine();


            //масив з рядків
            string[] names1 = { "Masha", "Petro", "Vasil" };

            //масив з об'єктів
            Person[] people = new Person[];

            //МЕТОДИ ДЛЯ МAСИВІВ
            int[] numbers4 = { 343, 2, 3, 4, 0, 12, 1, 55 };
            Console.WriteLine("Довжина масиву " + numbers4.Length);
            Console.WriteLine("Максимальне значення " + numbers4.Max());
            Console.WriteLine("Мінімальне значення " + numbers4.Min());
            Console.WriteLine("Максимальне значення " + numbers4.Max());
            Array.Reverse(numbers4);
            Console.WriteLine("Розвертаємо масив" + numbers4);
            Array.Sort(numbers4);
            Console.WriteLine("Сортуємо масив" + numbers4);

            Console.ReadLine();
        }
    }
}
