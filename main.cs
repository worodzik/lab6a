using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    double [] celsius = new double[7];
    double [] fahrenheit = new double[7];
     
    
    for(int count = 0; count< 7; count ++){
      Console.WriteLine("Enter temperature in celsius");
      celsius[count] = Convert.ToDouble(Console.ReadLine());
      fahrenheit [count] = ((celsius[count] * 9/5) + 32);
   }
    Array.Sort(fahrenheit);
    Array.Reverse(fahrenheit);
    Console.WriteLine("Temperatures in fahrenheit are :");
      
     foreach (int i in fahrenheit){
     Console.WriteLine(i);
     }
     double sum = fahrenheit.Sum();
     double ave = sum/7;
     Console.WriteLine("Avergae weekly temperature is " + ave);
 

  }
}