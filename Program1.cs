using System;

namespace PlayersAndMonsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split().ToArray();
            Hero hero = new Hero(temp[0], int.Parse(temp[1]));

            Console.WriteLine(hero.ToString());
            temp = Console.ReadLine().Split().ToArray();
            Wizard wiz = new Wizard(temp[0], int.Parse(temp[1]));

            Console.WriteLine(wiz.ToString());
        }
    }
}