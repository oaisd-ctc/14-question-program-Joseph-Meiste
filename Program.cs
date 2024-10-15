using System;

public class Program
{
    public static string name;
    public static int age;
    public static string eye;
    public static string hair;
    public static float shoe;
    public static string color;
    public static string movieTV;
    public static string teacher;
    public static string favclass;
    public static string holiday;
    public static string season;
    public static string job;
    public static string siblings;
    public static int sibling;
    public static int ageIn5Years;

    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();
        DisplaySummaryMessage();
    }

    public static void AskName()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
    }

    public static void AskAge()
    {
        Console.WriteLine("What is your age?");
        age = int.Parse(Console.ReadLine());
    }

    public static void AskEyeColor()
    {
        Console.WriteLine("What is your eye color?");
        eye = Console.ReadLine();
    }

    public static void AskHairColor()
    {
        Console.WriteLine("What is your hair color?");
        hair = Console.ReadLine();
    }

    public static void AskShoeSize()
    {
        Console.WriteLine("What is your shoe size?");
        shoe = float.Parse(Console.ReadLine());
    }

    public static void AskFavoriteColor()
    {
        Console.WriteLine("What is your favorite color?");
        color = Console.ReadLine();
    }

    public static void AskFavoriteTvShow()
    {
        Console.WriteLine("What is your favorite movie or TV show?");
        movieTV = Console.ReadLine();
    }


    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("What is your favorite teacher?");
        teacher = Console.ReadLine();
    }

    public static void AskFavoriteClass()
    {
        Console.WriteLine("What is your favorite class?");
        favclass = Console.ReadLine();
    }

    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("What is your favorite holiday?");
        holiday = Console.ReadLine();
    }

    public static void AskFavoriteSeason()
    {
        Console.WriteLine("What is your favorite season?");
        season = Console.ReadLine();
    }

    public static void AskDreamJob()
    {
        Console.WriteLine("What is your dream job?");
        job = Console.ReadLine();
    }

    public static void CalculateAgeIn5Years(int age)
    {
        ageIn5Years = (age + 5);
    }

    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        sibling = int.Parse(Console.ReadLine());
    }

    public static void DisplaySummaryMessage()
    {
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
                      + name + " will be " + ageIn5Years + " in five years" + ". "
                       + name + " has " + sibling + " siblings" + ".");
    }
}