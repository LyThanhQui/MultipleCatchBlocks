using System;

namespace MultipleCatchBlocks
{
    class Program
    {
        //Example1: Program to show how to implement multiple catch blocks in C#.
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
           // catch (Exception ex)
            //{
          //      Console.WriteLine("Catch Exeption");
       //    }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("second number should not be zero");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("enter only integer numbers");
            }
            Console.ReadKey();
        }

        
    }
}
