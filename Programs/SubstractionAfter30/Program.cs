using System;
using System.Linq;

namespace SubstractionAfter30
{
	public static class Program
	{
		public static void Main()
		{
			int b=Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(SubsAf30(b));
		}
		
		public static int SubsAf30(int a)
		{
			int sub=0;
			
			for (int i=a+1; i<=a+30; i++)
			{
				sub=sub-i;
				
			}

			return sub;
			
			
		}
	}
}