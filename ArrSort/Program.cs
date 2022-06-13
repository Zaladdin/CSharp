using System;
using System.Linq;

namespace ArrSort
{
	public static class Program
	{
		public static void Main()
		{
			int[] arr = {1,2,3,6,7,8,23,78,34,12};
			
			int x;
			
			for (int i=0; i<arr.Length-1; i++)
			{
				for (int j=i+1; j<arr.Length;j++)
				{
					if (arr[i]<arr[j])
					{
						x=arr[i];
						arr[i]=arr[j];
						arr[j]=x;
					}
				}
			}
			 Console.WriteLine("Отсортированный массив");
			 for(int i=0; i<arr.Length; i++)
			 {
			 	Console.WriteLine(arr[i]);
			 }
		
		}
	}
}