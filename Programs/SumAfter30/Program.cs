using System;
using System.Linq;

namespace SumAfter30
{
	public static class Program
	{
		public static void Main()
		{
			int b=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(SummAfter30(b));
		}
		
		public static int SummAfter30(int a)
		{
			int sum=0;
		//	a=Convert.ToInt32(Console.ReadLine());
			for (int i=a+1; i<a+31; i++)
			{
				sum=sum+i;
			}
			
			return sum;
		}
	}
}