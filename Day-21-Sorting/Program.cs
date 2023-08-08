using System.Linq;
using System;
using System.Collections.Generic;

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> givenList = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here
        int swap = 0;
        int length = givenList.Count;

        for (int i = 0; i < length; i++)
        {
            // Track number of elements swapped during a single array traversal

            for (int j = 0; j < length - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (givenList[j] > givenList[j + 1])
                {
                    int current = givenList[j];
                    givenList[j] = givenList[j + 1];
                    givenList[j + 1] = current;
                    swap++;
                }
            }

            // If no elements were swapped during a traversal, array is sorted
            if (swap == 0)
                break;
        }

        Console.WriteLine("Array is sorted in {0} swaps.", swap);
        Console.WriteLine("First Element: {0}", givenList[0]);
        Console.WriteLine("Last Element: {0}", givenList[length - 1]);

        Console.ReadLine();
    }
}
