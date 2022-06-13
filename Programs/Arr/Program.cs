using System;
using System.Linq;

namespace Arr
{
	public static class Program
	{
		public static void Main()
		{
			
			int[] arr={1,2,3,4,5,6};
			int[] arr1= new int [arr.Length];
			
			for (int i=0; i<arr1.Length; i++)
			{
			Console.WriteLine(arr1[i]);
			}

		}
	}
}