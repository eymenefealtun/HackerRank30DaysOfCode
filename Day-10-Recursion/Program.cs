using System;

class Result
{

    /*
     * Complete the 'factorial' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int factorial(int n) //recursive factorial method
    {

        if (n > 1)
            return n * factorial(n - 1);
        else
            return 1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Console.WriteLine(Result.factorial(n));

        Console.ReadLine();
    }
}
