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
            //АБСТРАКТНІ КЛАСИ
            //Animal animal = new Animal(); - не можемо так робити
            //Dog dog = new Dog();
            //dog.MakeSound();
            //Cat cat = new Cat();
            //cat.MakeSound();

            //ІНТЕРФЕЙСИ + АБСТРАКТНІ КЛАСИ
            Dog dog1 = new Dog("Bobik");
            Dog dog2 = new Dog("Sharik");
            Dog dog3 = new Dog("Rex");
            ///////////______________
            Chiken chika1 = new Chiken("Tsipa");
            Chiken chika2 = new Chiken("No Name");

            Tractor tractor = new Tractor("Belarus");

            dog1.MakeSound();
            chika1.MakeSound();
            chika2.MakeSound();
            tractor.MakeSound();

            chika1.GetLevelOfSound();
            chika1.SetSex(Sex.Male);

            Console.ReadLine();
        }
    }

    //АБСТРАКТНІ КЛАСИ
    //public abstract class Animal
    //{
    //    public abstract void MakeSound();

    //    public void Jump()
    //    {
    //        Console.WriteLine("Juuuump");
    //    }
    //}

    //public class Dog : Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Gav!");
    //    }
    //}

    //public class Cat : Animal
    //{ public override void MakeSound()
    //    {
    //        Console.WriteLine("Meow!");
    //    }
    //}

    //ІНТЕРФЕЙСИ
    public interface IMovable
    {
        int Speed { get; set; }

        void Move();
    }

    public class Car : IMovable
    {
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine("ЖЖЖЖЖЖЖж");
        }
    }

    public class Stone : IMovable
    {
        int speed = 0;
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine(".............О");
        }
    }

    //ПРИКЛАД 1 (СПІЛЬНЕ ЗАСТОСУВАННЯ)
    public interface IMakeSound
    {
        void MakeSound();
    }

    public abstract class Animal
    {
       public string Name { get; set; }

        public Animal(string name)
        { 
            Name = name;
        }

        public abstract void Eat();
    }

    public class Dog : Animal, IMakeSound
    {
        public int Age { get; set; }

        public Dog(string name) : base(name) { }

        public override void Eat() 
        {
            Console.WriteLine($"{Name} їсть кістку");
        }

        public void MakeSound()
        {
            Console.WriteLine("GAV!!");
        }
    }

    public class Chiken : Animal, IMakeSound
    {
        public Sex Sex { get; set; }

        public Chiken(string name) : base(name) { }

        public override void Eat()
        {
            Console.WriteLine($"{Name} їсть зерна");
        }

        public void MakeSound()
        {
            Console.WriteLine("KOO KOOOO KOOOOOOOOO!");
        }

        public void GetLevelOfSound()
        {
            Console.WriteLine(Convert.ToInt16(TypesOfSound.KoKoKo));
        }

        public void SetSex(Sex maleOrFemale)
        {
            Sex = maleOrFemale;

            Console.WriteLine("СТАТЬ " + Sex);
        }
    }

    public class Tractor : IMakeSound
    {
        public string Brand { get; set; }

        public Tractor(string brand) 
        { 
            Brand = brand;
        }

        public void Clear()
        {
            Console.WriteLine("Вивожу відходи!");
        }

        public void MakeSound()
        {
            Console.WriteLine("BIIIIP");
        }
    }


    //ENUM
    public enum TypesOfSound
    { 
        Gav = 70,
        Meow = 25,
        KoKoKo = 10,
        Ggggg = 100
    }

    public enum Sex
    {
        Male,
        Female
    }
}
