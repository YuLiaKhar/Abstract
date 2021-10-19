using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.ShowInfo();
            dog.ShowInfo();
            Console.WriteLine(dog.Say());
            Console.WriteLine(cat.Say());
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Say();
        public void ShowInfo()
        {
            Console.WriteLine("Название животного: {0}", Name);
            Console.WriteLine("Звук животного: {0}", Say());
        }
    }
    class Cat : Animal
    {
        string name = "Кошка";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        string sound = "Мяу";
        public override string Say()
        {
            return sound;
        }
    }
    class Dog : Animal
    {
        string name = "Собака";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string sound { get; set; }
        public override string Say()
        {
            return sound = "Гав";
        }
    }
}
