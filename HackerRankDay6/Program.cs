using System;

namespace HackerRankDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T, count=0;
            T = Convert.ToInt32(Console.ReadLine());
            while (count < T)
            {
                count++;
                string text = Console.ReadLine();
                for (int i = 0; i < text.Length; i += 2)
                {
                    Console.Write(text[i]);
                }
                Console.Write(" ");
                for (int j = 1; j < text.Length; j += 2)
                {
                    Console.Write(text[j]);
                }
                Console.WriteLine();
            }
            


        }
    }
}
