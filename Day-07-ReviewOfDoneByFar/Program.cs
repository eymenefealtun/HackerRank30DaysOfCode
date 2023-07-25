using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int numberOfSample = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> input = new List<string>();

        for (int i = 0; i < numberOfSample; i++)
            input.Add(Console.ReadLine());

        Console.Clear();



        for (int i = 0; i < input.Count; i++)
        {

            string left = String.Empty;
            string right = String.Empty;


            for (int j = 0; j < input[i].Length; j++)
            {
                if (j % 2 == 0)
                    left = left.Insert(left.Length, input[i].Substring(j, 1).ToString());
                else
                    right = right.Insert(right.Length, input[i].Substring(j, 1).ToString());

            }

            Console.WriteLine(left + " " + right);
        }

        Console.ReadLine();
    }
}