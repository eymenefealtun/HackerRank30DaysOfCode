using System;

class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        Console.Clear();

        if (N % 2 == 0)
        {

            if (N <= 5 && N >= 2)
                Console.WriteLine("Not Weird");
            else if (N >= 6 && N <= 20)
                Console.WriteLine("Weird");
            else if (N >= 20)
                Console.WriteLine("Not Weird");
        }
        else if (N % 2 != 0)
            Console.WriteLine("Weird");

        Console.ReadLine();
    }
}

        
#region Summary
//Objective
//In this challenge, we learn about conditional statements. Check out the Tutorial tab for learning materials and an instructional video.

//Task
//Given an integer, , perform the following conditional actions:

//If n is odd, print Weird
//If n is even and in the inclusive range of 2 to 5, print Not Weird        
//If n is even and in the inclusive range of 6 to 20, print Weird
//If n is even and greater than 20, print Not Weird
//Complete the stub code provided in your editor to print whether or not  is weird.

//Input Format

//A single line containing a positive integer, .

//Constraints
//1 <= n 1 <= 100

//Output Format

//Print Weird if the number is weird; otherwise, print Not Weird.

//Sample Input 0

//3
//Sample Output 0

//Weird
//Sample Input 1

//24
//Sample Output 1

//Not Weird
//Explanation

//Sample Case 0: n =3
//n is odd and odd numbers are weird, so we print Weird.

//Sample Case 1: 
//n>20 and is even, so it is not weird. Thus, we print Not Weird. 
#endregion