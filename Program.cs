﻿using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5, };

            //Dfine the query expression
            var result = numbers.
                Where(x => x % 2 == 0).
                Select(x => x * 10);

            //Execution the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}