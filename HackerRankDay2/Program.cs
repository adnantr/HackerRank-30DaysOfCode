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


namespace HackerRankDay2
{
    class Result
    {

        /*
         * Complete the 'solve' function below.
         *
         * The function accepts following parameters:
         *  1. DOUBLE meal_cost
         *  2. INTEGER tip_percent
         *  3. INTEGER tax_percent
         *  int meal_cost: bahşiş ve vergi öncesi yemeğin maliyeti
            int tip_percent: bahşiş yüzdesi
            int tax_percent: vergi yüzdesi
         */

        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip=((meal_cost/100)*tip_percent);
            double tax= ((meal_cost/100)*tax_percent);
            double Result = meal_cost + tip + tax;
            Console.WriteLine(Math.Round(Result));
            Console.ReadKey();
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            Result.solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
