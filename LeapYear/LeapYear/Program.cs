// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;



class Program {
  // Print Leap year

static void FindLeapYear(){
  int stYear, enYear;
  Console.WriteLine("Enter Starting Year");
  stYear = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter Ending Year");
  enYear = Convert.ToInt32(Console.ReadLine());

  for(int n = stYear; n <= enYear; n++){
      if((n % 4) == 0){
        Console.WriteLine("Leap Year {0}", n);
      }
  }
  
}
  public static void Main (string[] args) {
    FindLeapYear();
  }
}