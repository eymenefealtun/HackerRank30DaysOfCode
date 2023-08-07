using System;
using System.Collections.Generic;
using System.Linq;

public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        List<int> numbers = new List<int>();

        for (int i = 1; i <= n; i++)
            if (n % i == 0)
                numbers.Add(i);

        return numbers.Sum();
    }
}

class Solution
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}