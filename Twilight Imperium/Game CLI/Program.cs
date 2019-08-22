using System;
using Game_Core;

namespace Game_CLI
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      var context = new GameContext(6);
      while (context.Playing)
      {
        var input = Console.ReadLine();
        if (input == null)
        {
          return;
        }
        switch (FirstCommand(input))
        {
          case "next":
            context.Next();
            break;
          case "status":
            Console.WriteLine(context.Status());
            break;
          default:
            Console.WriteLine($"invalid command: {input}");
            break;
        }
      }
    }

    private static string FirstCommand(string input)
    {
      if (!input.Contains(" "))
      {
        return input;
      }
      var space = input.IndexOf(' ');
      return input.Substring(space);
    }
  }
}