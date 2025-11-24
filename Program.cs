// See https://aka.ms/new-console-template for more information

using System;

namespace operatorler
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama Operatörleri
            int a = 10;
            int b = 5;

            Console.WriteLine("Aritmetik Operatörler");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a % b = {a % b}");    // Mod alma

            Console.WriteLine("\nİlişkisel Operatörler");
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"a != b: {a != b}");
            Console.WriteLine($"a > b: {a > b}");
            Console.WriteLine($"a < b: {a < b}");
            Console.WriteLine($"a >= b: {a >= b}");
            Console.WriteLine($"a <= b: {a <= b}");

            Console.WriteLine("\nMantıksal Operatörler");
            bool x = true;
            bool y = false;
            Console.WriteLine($"x && y: {x && y}");  // AND
            Console.WriteLine($"x || y: {x || y}");  // OR
            Console.WriteLine($"!x: {!x}");          // NOT

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }
            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }
        }
    }
}
