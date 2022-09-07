using System;
using System.Collections.Generic;

namespace HackerRankDay8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                phoneBook.Add(input[0], input[1]);
            }
            bool flag = true;
            while (flag)
            {
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    flag = false;
                    break;
                }
                if (!phoneBook.ContainsKey(name))
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    Console.WriteLine("{0}={1}", name, phoneBook[name]);
                }
            }

        }
    }
}
