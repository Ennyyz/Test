using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinhDaNhiem
{
    abstract class Animal
    {
        public abstract void Speak();
        //{
        //    Console.WriteLine("Animal is speaking... ");
        //}
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat is speaking... ");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog is speaking... ");
        }
    }
    class Program
    {
        static void Main(string []args)
        {
            Animal cat = new Cat();
            cat.Speak();
            Animal dog = new Dog();
            dog.Speak();


            Console.ReadLine();
        }
    }
}
