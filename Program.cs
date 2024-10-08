using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your eye color?");
        string eye = Console.ReadLine();

        Console.WriteLine("What is your hair color?");
        string hair = Console.ReadLine();

        Console.WriteLine("What is your shoe size?");
        int shoe = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine();

        Console.WriteLine("What is your favorite movie or TV show?");
        string movieTV = Console.ReadLine();

        Console.WriteLine("What is your favorite teacher?");
        string teacher = Console.ReadLine();

        Console.WriteLine("What is your favorite class?");
        string favclass = Console.ReadLine();

        Console.WriteLine("What is your favorite holiday?");
        string holiday = Console.ReadLine();

        Console.WriteLine("What is your dream job?");
        string job = Console.ReadLine();

        Console.WriteLine("What is your favorite season?");
        string season = Console.ReadLine();

        Console.WriteLine("How many siblings do you have?");
        int siblings = int.Parse(Console.ReadLine());

        Console.WriteLine("My friend's name is " + name + ". "
         + name + " is " + age + " years old. "
          + name + " has " + eye + " colored eyes and has " + hair + " hair. "
           + name + "'s shoe size is " + shoe + ". "
            + name + "'s favorite color is " + color + ". "
             + name + "'s favorite movie/TV show is " + movieTV + ". "
              + name + "'s favorite teacher is " + teacher + ". "
               + name + "'s favorite class is " + favclass + ". "
                + name + "'s favorite holiday is " + holiday + ". "
                 + name + "'s dream job is " + job + ". "
                  + name + " will be " + (age + 5) + " in five years" + ". "
                   + name + " has " + siblings + " siblings" + ".");
    }
}