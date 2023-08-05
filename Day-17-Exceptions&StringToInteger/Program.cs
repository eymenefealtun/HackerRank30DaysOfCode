using System;

class Solution
{
    public static void Main(string[] args)
    {
        string S = Console.ReadLine();
		try
		{
			Console.WriteLine(Convert.ToInt32(S));
		}
		catch (Exception)
		{
			Console.WriteLine("Bad String");
		}
		Console.ReadLine();

    }
}
