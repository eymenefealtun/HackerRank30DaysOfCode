using System;

class Result
{

    /*
     * Complete the 'bitwiseAnd' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER N
     *  2. INTEGER K
     */
    public static int bitwiseAnd(int N, int K)
    {

        int val = 2;

        int tempResult = 0;
        int before = tempResult;
        int result = 0;
         
        for (int i = 1; i <= N; i++)                                 // i,j;
            for (int j = val++; j <= N; j++)                         // 1,2
            {                                                        // 1,3
                tempResult = i & j;                                  // 1,4
                if (tempResult < K && tempResult > before)           // 1,5
                {                                                    // 2,3
                    result = tempResult;                             // 2,4
                    before = tempResult;
                }
            }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int count = Convert.ToInt32(firstMultipleInput[0]);

            int lim = Convert.ToInt32(firstMultipleInput[1]);

            int res = Result.bitwiseAnd(count, lim);

            Console.WriteLine(res);
        }
        Console.ReadLine();
    }
}
