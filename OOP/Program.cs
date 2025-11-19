using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //МАСИВ
            int[] numbers = { 3, 454, 3, 3445, 12 };
            int[] numbers2 = new int[5];
            numbers2[0] = 23;

            //КОЛЕКЦІЇ
            //LIST - список
            List<string> store = new List<string>();
            store.Add("Помідори");
            store.Add("Сир");
            store.Add("Молоко");

            store.Remove("Сир");
            //store.RemoveAt(0); - видаляє по індексу
            //store.Find(); - шукає індекс елементу
            //store.Contains(); - є чи немає

            foreach (string item in store) 
            { 
                Console.WriteLine(item);
            }
            Console.ReadLine();


            //Dictionary - словник
            Dictionary<int, string> number = new Dictionary<int, string>();
            number.Add(1, "One");
            number.Add(2, "Two");
            number.Add(3, "Three");

            Dictionary<string, int> items = new Dictionary<string, int>();
            items.Add("Bananas", 34);
            items.Add("Apples", 12);
            items.Add("Potato", 55);

            Console.WriteLine(items["Bananas"]); //34

            items["Bananas"] = 65;

            Console.WriteLine(items["Bananas"]); //65

            items.ContainsKey("Bananas");


            //STACK<T>
            Stack<string> history = new Stack<string>();
            history.Push("google.com");
            history.Push("gmail.com");
            history.Push("github.com");

            Console.WriteLine(history.Pop());
            Console.WriteLine(history.Peek());

            //QUEUE<T>
            Queue<string> clients = new Queue<string>();
            clients.Enqueue("Client 1");
            clients.Enqueue("Client 2");

            Console.WriteLine(clients.Dequeue()); //Client 1


            //HASHSET<T>
            HashSet<int> numbers1 = new HashSet<int>();
            numbers1.Add(1);
            numbers1.Add(1); //не додасть
            numbers1.Add(2);

            numbers1.Remove(1);

            bool isPresent = numbers1.Contains(2); //є



            //REF та OUT
            int a = 5;
            int b = 3;

            AddOne(ref a);
            
            Console.WriteLine(AddOne(a, b));
            Console.WriteLine(a);

            if (TryDivide(5, 2, out int res))
            { 
                Console.WriteLine(res);
            }

        }

        //ref
        public static void AddOne(ref int a)
        {
            a++;
        }

        //out
        public static bool TryDivide(int a, int b, out int result)
        { 
            if (b == 0) 
            {
                result = 0;
                return false;
            }

            result = a / b;
            return true;
        }
    }
}
