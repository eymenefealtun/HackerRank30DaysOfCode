using System;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        IDictionary<string, string> phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            phoneBook.Add(input[0], input[1]);
        }

        string queryString = "";

        while ((queryString = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(queryString))
                Console.WriteLine(queryString + "=" + phoneBook[queryString]);
            else
                Console.WriteLine("Not found");
        }

        Console.ReadLine();

    }
}