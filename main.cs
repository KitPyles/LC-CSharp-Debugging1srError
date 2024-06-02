using System;

class MainClass {
  public static void Main (string[] args) {
    //Run this code first and examine the error message.
    //Fix the syntax error then run the code again to check your work.

    bool launchReady = false;
    int fuelLevel = 17000;

    if (fuelLevel >= 20000) { 
      Console.WriteLine("Fuel level cleared.");
      Console.WriteLine(!launchReady);
    } 
    else 
    {
      Console.WriteLine("WARNING: Insufficient fuel!");
      Console.WriteLine(launchReady);
    }
  }
}