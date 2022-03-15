using System;
using System.Linq;

class Program{
    
    public static void Main(){
      bool active = true;
      Console.WriteLine("--==Hex Code Generator==-- \n\n");
      while(active){
      Console.WriteLine("Generator Must Not Contain Any Letters.");
      Console.WriteLine("Hex Length? Default: 6");
      string length = Console.ReadLine();
    if (length.Length == 0)
    {
    Console.WriteLine("Your Random Hex Code: #"+Program.RandomHex(6)); 
    }
      else{
        int amount = Int32.Parse(length);
        Console.WriteLine("Your Random Hex Code: #"+Program.RandomHex(amount));
      }
        Console.WriteLine("Get New Hex? y/n");
        if (Console.ReadLine() == "y" || Console.ReadLine() == "Y")
        {
          active = true;
        }
      }
    }
  private static Random random = new Random();
  public static string RandomHex(int length)
  {
    const string chars = "1234567890ABCDEF";
    return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
  }
}