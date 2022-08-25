using System;

namespace SyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 11;
            var response = (answer < 9) ? "{answer} is less than nine" : "{answer} is greater than nine";
          
        }
    }
}
