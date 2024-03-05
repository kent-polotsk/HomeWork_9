using HomeWork_9;
using System.Text;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        const string Guide = "1 - Добавить травоядное животное\t2 - Убрать одно травоядное животное из вольера\n3 - Добавить хищное животное\t4 - Убрать одно хищное животное из вольера\n5 - Жизненный цикл\t6 - Просмотр вольеров\t7 - Инструкция\tESC - выход";

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Работа зоопарка");

        Random rand = new Random(); 
        MyZoo myZoo = new MyZoo();
        ConsoleKeyInfo key;
        PrintGuide();
        

        do
        {
            PressKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        CreateAnimal(rand.Next(1, 5), myZoo);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        myZoo.RemoveHerbivore();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        CreateAnimal(rand.Next(5, 9), myZoo);
                        break;
                    }
                case ConsoleKey.D4:
                    {
                        myZoo.RemovePredator();
                        break;
                    }
                case ConsoleKey.D5:
                    {
                        myZoo.LifeCycle();
                        break;
                    }
                case ConsoleKey.D6:
                    {
                        myZoo.Print();
                        break;
                    }
                case ConsoleKey.D7:
                    {
                        PrintGuide();
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        Environment.Exit(0);
                        break;
                    }
                default: break;

            }
        } while (true);

        void CreateAnimal(int i, MyZoo myZoo)
        {
            switch (i)
            {
                case 1:
                    {
                        myZoo.Add(new Rabbit());
                        break;
                    }
                case 2:
                    {
                        myZoo.Add(new Deer());
                        break;
                    }
                case 3:
                    {
                        myZoo.Add(new Camel());
                        break;
                    }
                case 4:
                    {
                        myZoo.Add(new Elephant());
                        break;
                    }
                case 5:
                    {
                        myZoo.Add(new Lion());
                        break;
                    }
                case 6:
                    {
                        myZoo.Add(new Bear());
                        break;
                    }
                case 7:
                    {
                        myZoo.Add(new Fox());
                        break;
                    }
                case 8:
                    {
                        myZoo.Add(new Tiger());
                        break;
                    }
                default: { break; }
            }
        }

        void PrintGuide()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Guide);
            Console.ResetColor();
        }

        void PressKey()
        {
            key = Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}