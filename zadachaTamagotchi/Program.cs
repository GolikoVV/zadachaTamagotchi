namespace zadachaTamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit pivo = new Fruit { type = "apple", heath = 10 };
            Console.WriteLine("Введите имя кота");
            Cat cat = new Cat(Console.ReadLine());
            Cat.Info(cat);
            while (cat.IsAlive())
            {
                Console.WriteLine("Меню: \n 1 - информация \n 2 - кошка помяукает \n 3 - покормить кошку \n 4 - Поест сама \n 5 - не кормить кошку \n");
                ConsoleKey Key = Console.ReadKey().Key;
                switch (Key)
                {
                    case ConsoleKey.D1:
                        Cat.Info(cat);
                        break;
                    case ConsoleKey.D2:
                        Cat.Meow(cat);
                        break;
                    case ConsoleKey.D3:
                        Cat.DoMeal(cat, pivo);
                        break;
                    case ConsoleKey.D4:
                        Cat.Eat(pivo);
                        break;
                    case ConsoleKey.D5:
                        Cat.Die(cat);
                        break;
                }
            }
        }
    }
}