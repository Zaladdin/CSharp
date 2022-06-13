
using System;
using System.Linq;

namespace Pr7
{
	public static class Program
	{
		public static void Main()
		{
            int a = Convert.ToInt32(Console.ReadLine());

            int sum =0;
            string b = Convert.ToString(a);
            int c =Convert.ToInt32(b.Length);
           
            Console.WriteLine($"{c} reqemli ededin  reqemlerinin cemi");


            for (int i = 0; i < c; i++)
            {
                
                    sum = sum + a % 10;
                    a = a / 10;
                    
                }
                Console.WriteLine(sum);
                
		}
	}
}

