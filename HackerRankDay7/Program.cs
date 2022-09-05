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


namespace HackerRankDay7
{
        class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arrTemp = new List<int>();
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            arrTemp.AddRange(arr);
            if(arrTemp.Count == n)
            {
                arrTemp.Reverse();
                foreach (int item in arrTemp)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }
            }
   
            



        }
    }
}

