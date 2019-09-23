using System;

namespace ConsoleApp
{
  class Program
  {
    public static decimal min = 1m;
    public static decimal max = 1000000m;
    public static decimal lower = 0;
    public static decimal upper = 0;
    public static decimal guess = 0;
    public static int tries = 0;

    static void Main(string[] args)
    {
      startGame();
      Inputs();
    }

    static void Inputs()
    {
      Console.WriteLine("Do you want to play a game?");
      var input = Console.ReadLine();
      while (input == "yes")
      {
        Console.WriteLine($"Is your number {guess}");
        var input2 = Console.ReadLine();
        if (input2 == "lower")
        {
          guessLower();
        }
        else if (input2 == "higher")
        {
          guessHigher();
        }
        else if (input2 == "yes")
        {
          Console.WriteLine($"I guessed it in {tries} tries");
          Environment.Exit(0);
        }
      }
    }

    static void startGame()
    {
      tries = 0;
      lower = min;
      upper = max;
      updateGame();
    }
    static void guessLower()
    {
      upper = guess;
      updateGame();
    }
    static void guessHigher()
    {
      lower = guess;
      updateGame();
    }
    static void updateGame()
    {
      guess = Math.Floor((lower + upper) / 2);
      tries++;
    }
  }
}