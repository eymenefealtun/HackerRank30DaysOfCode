using System;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Int32.Parse(Console.ReadLine());

        while (n-- > 0)
        {
            bool isPrime = true;

            int givenNumber = Int32.Parse(Console.ReadLine());

            if (givenNumber == 2)
                Console.WriteLine("Prime");
            else if (givenNumber < 2 || givenNumber % 2 == 0)
                Console.WriteLine("Not prime");
            else
            {
                for (int i = 3; i < givenNumber / 2; i += 2)
                    if (givenNumber % i == 0 && i != givenNumber)
                    {
                        isPrime = false;
                        break;
                    }
                if (isPrime == true)
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not prime");

            }
        }


    }
}