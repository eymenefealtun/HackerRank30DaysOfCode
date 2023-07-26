using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        //input:
        //4         --> number of elements
        //1 2 3 4   --> elements

        //output:
        //4 3 2 1

        int n = Convert.ToInt32(Console.ReadLine().Trim());
                
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
    
        Console.Clear();
        
        arr.Reverse();
    
        Console.WriteLine(string.Join(" ", arr));

        Console.ReadLine();
    }
}
