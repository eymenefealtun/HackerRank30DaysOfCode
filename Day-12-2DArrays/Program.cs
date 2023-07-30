using System.Collections.Generic;
using System.Linq;
using System;
class Solution
{
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int a = 0; a < 6; a++)             
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());

        Console.WriteLine(FindMaxSum(arr));

        Console.ReadLine();
    }

    private static int FindMaxSum(List<List<int>> arr)
    {

        int numberOfHourglasses = (arr.Count - 2) * (arr[0].Count - 2);

        int[] sumOfEachHourGlasses = new int[numberOfHourglasses];


        int lowerLimit = 0, middle = 1, upperLimit = 2;

        int i = 0, j = 0;

        int first = 0, second = 1, third = 2;


        while (i < numberOfHourglasses)
        {

            while (upperLimit < arr[0].Count)
            {

                for (int z = lowerLimit; z <= upperLimit; z++)
                {
                    sumOfEachHourGlasses[i] += arr[first][z];
                    sumOfEachHourGlasses[i] += arr[third][z];
                }
                sumOfEachHourGlasses[i] += arr[second][middle];


                lowerLimit++;
                upperLimit++;
                middle++;
                i++;
            }


            lowerLimit = 0;
            middle = 1;
            upperLimit = 2;

            first++;
            second++;
            third++;

        }

        return sumOfEachHourGlasses.Max();
    }

}