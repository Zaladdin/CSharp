using System;
using System.Linq;

namespace Ededolan
{
	public static class Program
	{
		public static void Main()
		{
			int[] arr={1,2,3,6,7,8,23,78,34,12};
			
			for (int i=0; i<arr.Length; i++)
			{
				if (arr[i]/10==3 ^ arr[i]%10==3)
				{
					Console.WriteLine(arr[i]);
				}
				
			}


		}
	}
}