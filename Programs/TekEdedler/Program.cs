using System;
using System.Linq;

namespace Təkededler
{
	public static class Program
	{
		public static void Main()
		{
			int[] arr={1,2,3,6,7,8,23,78,34,12};

			

			for (int i=0; i<arr.Length; i++)
			{
				if (arr[i]%2==1)
				{
					int[] arr1= new int [arr.Length];
					arr1[i] = arr[i];
					Console.WriteLine(arr1[i]);
				}
			}	

		}
	}
}