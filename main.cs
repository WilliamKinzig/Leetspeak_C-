using System;
class Leetspeak
{
  public string userInput { get; set;}

  // public Leetspeak(string input)
  // {
  //   userInput = input;
  // }

  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Enter a word or sentence! owo");
      string userInput = Console.ReadLine();

      char[] userArray = userInput.ToCharArray();

      for(int i = 0; i < userArray.Length; i++)
      {
        if (userArray[i] == 'e' || userArray[i] == 'E')
        {
          userArray[i] = '3';
        }
        else if (userArray[i] == 'o' || userArray[i] == 'O')
        {
          userArray[i] = '0';
        }
        else if (userArray[i] == 'l')
        {
          userArray[i] = 'w';
        }
        else if (userArray[i] == 'L')
        {
          userArray[i] = 'W';
        }
        else if (userArray[i] == 't' || userArray[i] == 'T')
        {
          userArray[i] = '7';
        }
        else if (userArray[i] == 'a' || userArray[i] == 'A')
        {
          userArray[i] = '4';
        }
        else if (userArray[i] == 's' && i != 0 && userArray[i-1] != ' ')
        {
          userArray[i] = 'z';
        }
        else if (userArray[i] == 'S' && i != 0 && userArray[i-1] != ' ')
        {
          userArray[i] = 'Z';
        }
      }
      string userResult = string.Join("", userArray);

      Console.WriteLine(userResult);
    }
  }
}
