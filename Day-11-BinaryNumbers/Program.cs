using System;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string[] strings = Convert.ToString(n, 2).Split('0');

        int numberOfOnes = strings.Max().Length;

        Console.Clear();

        Console.WriteLine(numberOfOnes);

        Console.ReadLine();
    }
}