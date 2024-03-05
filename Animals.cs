using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{

    abstract class Animal
    {
        public string? Name { get; init; }
        protected bool isHungry = true;
        protected DateTime EatTime;
        public virtual void Live()
        {
            Console.WriteLine("Животное живет");
            isHungry = true;
            EatTime = DateTime.Now;
        }
    }

    class Herbivore : Animal
    {
        public override void Live()
        {
            EatGrass();
        }
        private void EatGrass()
        {
            isHungry = DateTime.Now.Subtract(EatTime).TotalMilliseconds >= 4000 ? true : false;
            if (isHungry)
            {
                Console.Write($"Травоядное {Name} ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ест травку");
                Console.ResetColor();
                isHungry = false;
                EatTime = DateTime.Now;

            }
            else  Console.WriteLine($"Травоядное {Name} не голодно");
            Thread.Sleep(300);
        }
    }

    class Predator : Animal
    {
        public override void Live()
        {
            Bite();
        }
        public void Bite()
        {
            isHungry = DateTime.Now.Subtract(EatTime).TotalMilliseconds >= 6000 ? true : false;
            if (isHungry)
            {
                Console.Write($"Хищник {Name} ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("охотится");
                Console.ResetColor();
                isHungry = false;
                EatTime = DateTime.Now;
            }
            else  Console.WriteLine($"Хищник {Name} не голоден");
            Thread.Sleep(300);
        }
    }

    class Rabbit : Herbivore
    {
        public Rabbit()
        { Name = "Rabbit"; }
    }

    class Deer : Herbivore
    {
        public Deer()
        { Name = "Deer"; }
    }
    class Camel : Herbivore
    {
        public Camel()
        { Name = "Camel"; }
    }

    class Elephant : Herbivore
    {
        public Elephant()
        { Name = "Elephant"; }
    }

    class Lion : Predator
    {
        public Lion()
        { Name = "Lion"; }
    }

    class Bear : Predator
    {
        public Bear()
        { Name = "Bear"; }
    }
    class Fox : Predator
    {
        public Fox()
        { Name = "Fox"; }
    }

    class Tiger : Predator
    {
        public Tiger()
        { Name = "Tiger"; }
    }
}
