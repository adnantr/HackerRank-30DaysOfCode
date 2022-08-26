using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace HackerRankDay3
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            if (N % 2 == 0)
            {
                if (2 < N && N < 5)
                {
                    Console.WriteLine("Not Weird");
                }
                if (6 < N && N <= 20)
                {
                    Console.WriteLine("Weird");
                }
                if (N > 20)
                {
                    Console.WriteLine("Not Weird");
                }
            }
        }
    }

}
