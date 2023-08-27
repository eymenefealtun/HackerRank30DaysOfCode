using System;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int fine = 0;

        string[] returnDates = Console.ReadLine().ToString().Split();
        string[] dueDates = Console.ReadLine().ToString().Split();

        int dueDay = Convert.ToInt32(dueDates[0]), dueMonth = Convert.ToInt32(dueDates[1]), dueYear = Convert.ToInt32(dueDates[2]);
        int returnDay = Convert.ToInt32(returnDates[0]), returnMonth = Convert.ToInt32(returnDates[1]), returnYear = Convert.ToInt32(returnDates[2]);

        DateTime dueDate = new DateTime(dueYear, dueMonth, dueDay);
        DateTime returnDate = new DateTime(returnYear, returnMonth, returnDay);


        int totalDay = Convert.ToInt32((returnDate - dueDate).TotalDays);
        int totalMonth = Convert.ToInt32((returnDate - dueDate).TotalDays)/30;

        if (totalDay <= 0)
            fine = 0;
        else if (totalDay > 0 && dueMonth == returnMonth && dueYear == returnYear)
            fine = 15 * (returnDay - dueDay);
        else if (returnMonth > dueMonth && dueYear == returnYear)
            fine = 500 * totalMonth;
        else 
            fine = 10000;


        Console.WriteLine(fine);
        Console.ReadLine();
    }
}