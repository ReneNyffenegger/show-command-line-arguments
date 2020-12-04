using System;

public class ShowArgs {

   static void Main(String[] argv) {
      Console.WriteLine($"{System.AppDomain.CurrentDomain.FriendlyName}: argument count is {argv.Length}:");
      foreach (var arg in argv) {
         Console.WriteLine("  " + arg);
      }
   }
}
