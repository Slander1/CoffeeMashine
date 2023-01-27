using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Human human = new Human();

            RojkoveMashine rojkoveMashine = new RojkoveMashine();
            CapsuleMashine capsuleMashine = new CapsuleMashine();

            human.CookCoffee(rojkoveMashine, 0);
            Console.WriteLine();

            human.CookCoffee(capsuleMashine, 0);
            Console.WriteLine();

            human.CookCoffee(rojkoveMashine, 1);
            Console.WriteLine();

            human.CookCoffee(capsuleMashine, 1);
            Console.WriteLine();

            human.CookCoffee(rojkoveMashine, 2);
            Console.WriteLine();
            
            human.CookCoffee(capsuleMashine, 2);

        }
    }
}