using System;

namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;
      
      
      
      double numberOneSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberOne)));
      
      double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
      
      Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));




    }
  }
}

