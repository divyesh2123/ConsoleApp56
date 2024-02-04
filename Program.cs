using System;

namespace ConsoleApp56
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int row = 1; row <=3; row= row+1)
            {

                for(int space=3; space>row;space=space-1)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <=row; col = col +1)
                {
                    Console.Write(col);

                }
                Console.WriteLine();
               
            }

            Console.ReadKey();

        }
    }
}
