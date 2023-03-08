using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace zadachaTamagochi
{
    public struct Fruit
    {
        public int heath;
        public string type;
    }
    class Cat
    {
        private string name;
        private string color;
        private int health;

        public Cat(string name = "Null")
        {
            this.name = name;
            health = 100;
        }
        public static void Meow(Cat meow)
        {
            Console.WriteLine("Мяу");
        }
        public static void Eat(Fruit fruit)
        {
            Console.WriteLine($"Кошка съела {fruit.type}.{fruit.heath} Здоровья");
        }
        public static void DoMeal(Cat a, Fruit fruit)
        {
            Cat.Eat(fruit);
            a.health = a.health - fruit.heath;
            if (a.health <= 0)
                Console.WriteLine(" кошка погибла");
        }
        public static void Info(Cat a)
        {
            Console.WriteLine($"{a.name}, {a.color}, {a.health} HP");
        }
        public static void Die(Cat a)
        {
            --a.health;
            Console.WriteLine(a.health);
            if (a.health <= 0)
                Console.WriteLine("кошка погибла");
        }
        public bool IsAlive()
        {
            bool flag = true;
            if (health <= 0)
            {
                flag = false;
            }
            return flag;
        }
    }
}