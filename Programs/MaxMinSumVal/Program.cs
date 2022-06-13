using System;
using System.Linq;

namespace MaxMinSumVal
{
	public static class Program
	{
		public static void Main()
		{
			int[] arr = { 1, 2, 3, 6, 7, 8, 23, 78, 34, 12 };
			int val=0;
			int   max = int.MinValue;
			int   min = int.MaxValue;
			int[] arr1 = new int[arr.Length];

			for (int i=0; i<arr.Length; i++)
			{
				val=arr[i]/10+arr[i]%10;
				arr1[i]=val;
				Console.WriteLine(arr1[i]);
			}
			
			

			
			for (int j=0; j<arr.Length; j++)
			{
				if (arr1[j]>max)
				{
					max=arr1[j];
				}
				
				if (arr1[j]<min)
				{
					min=arr1[j];
				}
			}
			
			
		
					Console.WriteLine($"Ededlerin arasında reqemlerinin cemi en boyuk olan eded: {max}");
			       Console.WriteLine($"Ededlerin arasında reqemlerinin cemi en kicik olan eded: {min}");
		
			

		}
	}
}