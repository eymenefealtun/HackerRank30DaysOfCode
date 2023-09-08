using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        List<string> firstNames = new List<string>();
        List<string> emails = new List<string>();

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];
            firstNames.Add(firstName);
            string emailID = firstMultipleInput[1];
            emails.Add(emailID);
        }

        List<int> correctIndexes = new List<int>();
        for (int i = 0; i < emails.Count(); i++)
        {
            if (emails[i].Contains("@gmail.com"))
                correctIndexes.Add(i);
        }

        List<string> correctNames = new List<string>();
        for (int i = 0; i < firstNames.Count(); i++)
        {
            if (correctIndexes.Contains(i))
            {
                correctNames.Add(firstNames[i]);
            }
        }

        List<string> sortedCorrectNames = correctNames.OrderBy(x => x).ToList();
        for (int i = 0; i < correctNames.Count(); i++)
        {
            Console.WriteLine(sortedCorrectNames[i]);
        }

        Console.ReadLine();
    }
}
