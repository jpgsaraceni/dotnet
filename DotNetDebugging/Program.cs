// This code is NOT mine. It's just an example from the Microsoft Learn course to show the
// use of VSCode debugger. I only wrote line 23.

using System;

namespace DotNetDebugging
{
  class Program
  {
    static void Main(string[] args)
    {
      int result = Fibonacci(5);
      Console.WriteLine(result);
      Console.ReadKey(true);
    }
    static int Fibonacci(int n)
    {
      int n1 = 0;
      int n2 = 1;
      int sum = 0;

      // for (int i = 2; i < n; i++) // original code line
      for (int i = 2; 1 <= n; i++) // debugged
      {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
      }
      return n == 0 ? n1 : n2;
    }
  }
}