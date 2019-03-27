using System;

namespace rockit
{
  class Program
  {
    static void Main(string[] args)
    {




      Console.WriteLine("Rock Paper Scissors!");
      bool playing = true;
      Random rand = new Random();
      while (playing)
      {
        System.Console.Write("enter choice :");
        string input = Console.ReadLine().ToLower();
        string[] arrInputs = { "rock", "paper", "scissor" };
        if (Array.IndexOf(arrInputs, input) == -1)
        {
          Console.WriteLine("TRY HARDER");
          continue;
        }
        string[] arrRes = { "rock", "paper", "scissor" };
        int index = rand.Next(arrRes.Length);
        Console.WriteLine($"Computer Choice:{arrRes[index]}");
        if (index == 0 && input == "rock")
        {
          Console.WriteLine("TIE");
        }

      }
    }
  }
}

