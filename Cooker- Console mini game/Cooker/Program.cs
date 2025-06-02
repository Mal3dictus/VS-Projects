using System;

namespace Cooker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
           
            string[] Ingred = {"Fish","Meat","Carrot", "Potato", "Lettuce","Cheese","Cabage","Tomato","Lemon","Sause"};
            Console.WriteLine("COOKER");
            Console.WriteLine("Type anything to play!");
            Console.ReadLine();
            while (true)
            {
                Console.Clear();
                Console.Write("Rules:");
                Console.WriteLine("Each round you are dictated a product and you need to pick the right one.\n Once a product is named you need to type back the number to it.\n Be careful with what product you pick because one mistake is a gameover.");
                Console.WriteLine("Type the number for the following item:\n 0 - Fish\n 1 - Meat\n 2 - Carrot\n 3 - Potato\n 4 - Lettuce\n 5 - Cheese\n 6 - Cabage\n 7 - Tomato\n 8 - Lemon\n 9 - Sause");
                Console.WriteLine("Type anyhting when ready!");
                Console.ReadLine();
                while (true)
                {
                    Console.Clear();
                    Random random = new Random();
                    int ind = random.Next(Ingred.Length);
                    Console.WriteLine($"Ok so it should be:{ Ingred[ind]}");
                    Console.WriteLine("\n 0 - Fish\n 1 - Meat\n 2 - Carrot\n 3 - Potato\n 4 - Lettuce\n 5 - Cheese\n 6 - Cabage\n 7 - Tomato\n 8 - Lemon\n 9 - Sause");
                    Console.WriteLine($"Score:{score}");
                    int ginput=int.Parse(Console.ReadLine());

                    if(ginput == ind)
                    {
                        score++;
                    }
                    else if (ginput != ind)break;
                    
                }
                Console.Clear();
                Console.WriteLine("Gameover!");
                Console.WriteLine($"Score:{score}");
                Console.WriteLine("Try again by pressing anything or exit by typing 0:");
                int minput=int.Parse(Console.ReadLine());
                if (minput == 0) break;
               
            }
        }
    }
}
