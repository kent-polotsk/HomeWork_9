using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{
    internal class MyZoo
    {
        List<Animal> Herbivores = new List<Animal>();
        List<Animal> Predators = new List<Animal>();
        Random random = new Random();
        internal MyZoo() { }
        internal void Add(Animal NewAnimal)
        {
            if (NewAnimal != null)
            {
                Type type = NewAnimal.GetType();
                if (type.BaseType == typeof(Predator))
                {
                    Predators.Add(NewAnimal);
                    Console.WriteLine($"{NewAnimal.Name} помещен в вольер к хищникам");
                }
                else if (type.BaseType == typeof(Herbivore))
                {
                    Herbivores.Add(NewAnimal);
                    Console.WriteLine($"{NewAnimal.Name} помещен в вольер к травоядным");
                }
                else Console.WriteLine($"Неизвестный тип животного ");
            }
            else Console.WriteLine("NULL");
        }
        internal void RemovePredator()
        {
            if (Predators.Count > 0)
            {
                int i = random.Next(0, Predators.Count - 1);
                Console.WriteLine($"{Predators[i].Name} удален из вольера хищников");
                Predators.RemoveAt(i);
            }
            else { Console.WriteLine("Вольер хищников пуст"); }
        }
        internal void RemoveHerbivore()
        {
            if (Herbivores.Count > 0)
            {
                int i = random.Next(0, Herbivores.Count - 1);
                Console.WriteLine($"{Herbivores[i].Name} удален из вольера травоядных");
                Herbivores.RemoveAt(i);
            }
            else { Console.WriteLine("Вольер травоядных пуст"); }
        }


        internal void Print()
        {
            if (Herbivores.Count > 0)
            {
                Console.WriteLine("В вольере травоядных находятся:");
                Console.Write(string.Join(", ", Herbivores.Select(x => x.Name)));
                Console.WriteLine();
            }
            if (Predators.Count > 0)
            {
                Console.WriteLine("В вольере хищников находятся:");
                Console.Write(string.Join(", ", Predators.Select(x => x.Name)));
                Console.WriteLine();
            }
            if ((Herbivores.Count == 0 || Herbivores == null) & (Predators == null || Predators.Count == 0)) Console.WriteLine("Вольеры пусты");
        }
        internal void LifeCycle()
        {
            if (Herbivores.Count > 0 || Predators.Count > 0)
            {
                foreach (var animal in Herbivores) animal.Live();
                foreach (var animal in Predators) animal.Live();
            }
            else Console.WriteLine("Зоопарк пуст");
        }
    }
}
