using System;
using System.Linq;

namespace PowBy3
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			//int b=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(PowBy3 (3));
		}
		
		public static int PowBy3(int a)
		{
			 a=Convert.ToInt32(Console.ReadLine());
			int pow3= Convert.ToInt32(Math.Pow(a, 3));
			return pow3;
		}

		
		

}
}