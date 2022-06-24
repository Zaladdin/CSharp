using System;
using System.Linq;

namespace IsPrime
{
	public static class Program
	{
		public static void Main()
		{
			int b =0;
			b=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(IsPrime(b));

		}
		
		public static bool IsPrime(int a)
		{
			for (int i=2; i<Math.Sqrt(a)+1; i++)
			{
				if(a%i==0)
				{
					return false;
				}
				
			}
			
			return true;
			
			
			
			
		}
	}
}