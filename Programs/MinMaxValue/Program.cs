using System;
using System.Linq;

namespace MinMaxValue
{
	public static class Program
	{
		public static void Main()
		{
			int[] arr={1,2,3,6,7,8,23,78,34,12};
		
			
			int   max = int.MinValue;
			int   min = int.MaxValue;
			
			for (int i=0; i<arr.Length; i++)
			{
				if (arr[i]>max)
				{
					max=arr[i];
				}
				
				if (arr[i]<min)
				{
					min=arr[i];
				}
			}
			
			Console.WriteLine(max);
			Console.WriteLine(min);
		}
	}
}