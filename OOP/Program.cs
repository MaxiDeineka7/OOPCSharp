using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //МЕТОД З ПАРАМЕТРОМ
            //SaySomething("Maksym");
            //SaySomething("Andriy");

            //МЕТОД З ПАРАМЕТРОМ ЗА ЗАМОВЧУВАННЯМ
            //int sum1 = Add(5);
            //SaySomething(Convert.ToString(sum1));

            //ПЕРЕВАНТАЖЕНИЙ МЕТОД (INT)
            //int sum2 = Add(5,7);
            //SaySomething(Convert.ToString(sum2));

            //ПЕРЕВАНТАЖЕНИЙ МЕТОД (DOUBLE)
            //double sum3 = Add(5.65, 7.21);
            //SaySomething(Convert.ToString(sum3));

            //ПЕРЕВАНТАЖЕНИЙ МЕТОД (STRING)
            //string sum4 = Add("1", "4");
            //SaySomething(sum4);

            Book firstBook = new Book();
            firstBook.PrintInfo();

            Book secondBook = new Book("OOП", "Deineka Maksym");
            secondBook.PrintInfo();

            Book thirdBook = new Book("OOП 2.0", "Vinnychuk Igor", 500);
            thirdBook.PrintInfo();

            secondBook.Price = 45;
            secondBook.PrintInfo();
            secondBook.Discount();
            secondBook.PrintInfo();

            Console.ReadLine();

        }

        //[модифікатор доступу] [static \ пусто] [void] Ім'я(параметри)
        public static void SaySomething(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public static int Add(int a, int b = 1)
        {           
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(string a, string b)
        {
            return a + b;
        }
    }


    /// <summary>
    ///  КЛАС
    /// </summary>
    class Book 
    {
        //Поля
        private string title;
        private string author;
        private double price;

        //Властивості
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Price
        {
            get { return Convert.ToInt16(price); }
            set 
            {
                if (value >= 0)
                {
                    price = Convert.ToDouble(value);
                }
            }
        }

        //Конструктори
        public Book()
        {
            title = "Невідома назва";
            author = "Невідомий автор";
            price = 0;
        }
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            price = 0;
        }
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        //Методи
        public void PrintInfo()
        {
            Console.WriteLine($"Назва: {title}, Автор: {author}, Ціна: {price} грн");
        }

        public void Discount()
        {
            price = price * 0.95;
        }
    }
}
