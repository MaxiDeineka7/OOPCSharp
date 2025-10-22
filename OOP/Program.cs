using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //УНАСЛІДУВАННЯ
            //BaseClass e1 = new BaseClass();
            //e1.ShowMessage();

            //ChildClass e2 = new ChildClass();
            //e2.AnotherMessage();
            //e2.ShowMessage();

            //ВИКЛИК BASE КОНСТРУКТОРА + OVERRIDE
            //Animal[] animals = new Animal[]
            //{
            //    new Dog("Red", "Rex"),
            //    new Cat("Silver"),
            //    new Animal("OOOO")
            // };

            //foreach (Animal animal in animals)
            //{
            //    animal.MakeSound();
            //}

            //АБСТРАКТНІСТЬ
            //Dog dog = new Dog("Black", "Rex");
            //dog.MakeSound();

            //ІНКАПСУЛЯЦІЯ
            Student student = new Student();
            //student.Age = -10; //помилка
            student.Age = 10;
            student.Score = 55;



            Console.ReadLine();

        }

        //УНАСЛІДУВАННЯ
        class BaseClass
        {
            public void ShowMessage()
            {
                Console.WriteLine("Hey! It`s Base class");
            }
        }

        class ChildClass : BaseClass
        {
            public void AnotherMessage()
            {
                Console.WriteLine("Hey! It`s Child class");
            }
        }

        //ВИКЛИК BASE КОНСТРУКТОРА + OVERRIDE
        abstract class Animal
        {
            public string Color;

            public Animal(string color)
            {
                Color = color;
            }

            //public virtual void MakeSound() 
            //{
            //    Console.WriteLine("Animal sound");
            //}

            public abstract void MakeSound();
        }

        class Dog : Animal
        {
            public string Name;

            public Dog(string color, string name) : base(color)
            {
                Name = name;
            }

            public override void MakeSound()
            {
                Console.WriteLine("Wooof");
            }
        }

        class Cat : Animal
        {
            public Cat(string color) : base(color) { }

            public override void MakeSound()
            {
                Console.WriteLine("MEOWWW");
            }
        }

        //ІНКАПСУЛЯЦІЯ
        //ТАК НЕ РОБІТЬ! ТУТ МОЖНА ВКАЗАТИ ВІК -10
        //public class Student
        //{
        //    public string Name;
        //    public int Age;
        //}

        //ТАК РОБІТЬ!
        public class Student
        {
            public int Age
            {
                get { return Age; }
                set
                {
                    if (value > 0 && value < 120)
                    {
                        Age = value;
                    }
                    else 
                    {
                        Console.WriteLine("Ти шо, тю тю?");
                    }
                }
            }
            
            //АВТОМАТИЧНА ВЛАСТИВІСТЬ
            public int Score { get; private set; }

        }
    }
}
