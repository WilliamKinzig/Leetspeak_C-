namespace Leetspeak
{
  public class Translator
  {
    public static bool returnTest(string userInput)
    {
      char[] userArray = userInput.ToCharArray();

      for(int i = 0; i < userArray.Length; i++)
      {
        if (userArray[i] == 'e')
        {
          userArray[i] = '3';
        }
      }
      string userResult = string.Join("", userArray);
      if(userResult == "h3llo"){
        return true;
      }
      else{
        return false;
      }
    }

  }
}
