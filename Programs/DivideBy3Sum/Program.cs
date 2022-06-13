using System;
using System.Linq;

namespace DivideBy3Sum
{
	public static class Program
	{
		public static void Main()
		{
			int x=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(DivideSumBy3(x));

		}
		
		public static bool DivideSumBy3(int a)
		
		{
			 int sum=Sum(a);
			 if (sum%3==0)
			 {
			 	return true;
			 }
			 else 
			 {
			 	return false;
			 }
			
		}
		
		public static int Sum(int a)
		{
			  int sum =0;
			 

             string b = Convert.ToString(a);

             int c =Convert.ToInt32(b.Length);
           
             for (int i = 0; i < c; i++)
              
                {
                    sum = sum + a % 10;
                    a = a / 10;
                    
                }
                return sum;
		}
	}
}