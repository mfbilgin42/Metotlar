using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    class FourOperations
    {
        public void Gather(int number1 , int number2)
        {
            int total = number1 + number2;
            Console.WriteLine("Sonuç : " + total);
        }
        public void Extraction(int number1, int number2)
        {
            int total = number1 - number2;
            Console.WriteLine("Sonuç : " + total);
        }
        public void Division(int number1, int number2)
        {
            int total = number1 / number2;
            Console.WriteLine("Sonuç : " + total);
        }
        public void Multiplication(int number1, int number2)
        {
            int total = number1 * number2;
            Console.WriteLine("Sonuç : " + total);
        }
    }
}
