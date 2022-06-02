// See https://aka.ms/new-console-template for more information


using System;

namespace CSharp05Group

{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            int x;
            
            Console.WriteLine("Введите текст, которую хотите повторить:");
            test = Console.ReadLine();


            Console.WriteLine("Введите колличество повтора: ");
            x = Convert.ToInt32(Console.ReadLine());

           

            for (int i=0; i<x; i++)
            {
                Console.WriteLine(test);  
            }
        }
    }
}
