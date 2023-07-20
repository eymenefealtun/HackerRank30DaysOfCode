using System;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        // Read and save an integer, double, and String to your variables.
        int userI = Convert.ToInt32(Console.ReadLine());
        double userD = Convert.ToDouble(Console.ReadLine());
        string userS = Console.ReadLine();
        Console.Clear();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + userI);

        // Print the sum of the double variables on a new line.
        decimal plusDouble = (decimal)(d + userD);
        Console.WriteLine(String.Format("{0:0.0}", plusDouble)) ;
        
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + userS);

        // The 's' variable above should be printed first.
        Console.ReadLine();
    }
}