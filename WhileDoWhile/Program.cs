using System;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Stars Do You Want To See ?!");
            int Number = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            while (x<Number)
            {
                Console.Write("*");
                x++;
            }
            //------------------------------------------------------------
            int game;
            do
            {
                Console.WriteLine("\n What Game Do You Want To Play ? 1 Or 2 ? Pleas Insert 0 To Exit !");
                game = Convert.ToInt32(Console.ReadLine());
                if (game == 1)
                {
                    Console.WriteLine("Game 1 Is Selected !");
                }
                else if (game == 2)
                {
                    Console.WriteLine("Game 2 Is Selected !");
                }

            }
            while (game != 0);
        }
    }
}
