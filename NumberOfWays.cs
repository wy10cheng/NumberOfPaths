//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world! " + NumberOfWays(610) );
        }
        
        public static int NumberOfWays (int n)
        {
            if (n<1) return 0;
            if (n==1) return 1;
            return NumberOfWays (n-1) + NumberOfWays (n-2) + NumberOfWays (n-3) + NumberOfWays (n-4) + NumberOfWays (n-5) + NumberOfWays (n-6);
        
        }

    }
}