using System;
using System.Linq;

namespace Divide3
{
	public static class Program
	{
		public static void Main(string[] args)
		{
		//	a=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(DivideBy3 (a));
		}
			public static bool DivideBy3(int a)
			{
			
			a=Convert.ToInt32(Console.ReadLine());
			if (a%3==0)
			{
				return true;
			}
			
			else 
			{
				return false;
			}
			 

		}
	}
}