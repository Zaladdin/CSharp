using System;
using System.Linq;

namespace MultiplicationAfter30
{
    public static class Program
{
	public static void Main()
	{
		Console.WriteLine(MultiplicationAfter30 (1));
	}
	
	public static int MultiplicationAfter30(int a)
	{
		int mult=1;
		a=Convert.ToInt32(Console.ReadLine());
		for (int i=a+1; i<=a+30;i++)
		{
			mult=mult*i;
		}
		
		return mult;
	}
}
}