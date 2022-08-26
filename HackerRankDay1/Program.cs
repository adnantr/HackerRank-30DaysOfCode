using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        string.Format("{0:#.0}", 0.0);

        Console.WriteLine("Integer bir değer giriniz:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Double bir değer giriniz:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("String bir değer giriniz:");
        string c = Convert.ToString(Console.ReadLine());
        int IntResult = a + i;
        double DoubleResult = d + b;
        
        Console.WriteLine(IntResult);
        Console.WriteLine(DoubleResult);
        Console.WriteLine("{0}{1}",s,c);
        Console.ReadKey();

    }
}