using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person()
    {

    }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    string _firstName;
    string _lastName;
    int _id;
    int[] _scores;
    public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
    {
        _firstName = firstName;
        _lastName = lastName;
        _id = id;
        _scores = scores;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    internal char Calculate()
    {
        int number = 0;

        for (int i = 0; i < _scores.Length; i++)
            number += _scores[i];

        int average = number / _scores.Length;
        char value = ' ';

        if (average <= 100 && average>= 90)
            value = 'O';
        else if (average < 90 && average >= 80)
            value = 'E';
        else if (average < 80 && average >= 70)
            value = 'A';
        else if (average < 70 && average >= 55)
            value = 'P';
        else if (average < 55 && average >= 40)
            value = 'D';
        else if (average < 40)
            value = 'T';

        return value;
    }

}

class Solution
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
        Console.ReadLine();
    }
}