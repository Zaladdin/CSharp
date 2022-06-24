using System;
using System.Linq;

namespace CalcAvg
{
	public static class Program
	{
		public static void Main()
		{
				int b=0;



			Console.WriteLine("Fennin sayini yazin");

			b= Convert.ToInt32(Console.ReadLine());
		int[] arr1=new int [b];
		
		for(int i=0;i<arr1.Length; i++)
		{
			Console.WriteLine(i+1 + " fennin qiymeti");
			arr1[i]=Convert.ToInt32(Console.ReadLine());
		
			
			
		}
			
			Console.WriteLine(CalcAvg(arr1));
		

			
		
	
		
		}
		
		public static int CalcAvg (params int[] arr)
		{
		
			int sum=0;
			int res=0;
			foreach(int item in arr)
			{
				sum+=item;
				
			}
			res = sum/arr.Length;
		
			
			
			
			
			if(res>60)
			{
				Console.WriteLine("mezun oldunuz");
				
			}
			else
			{
				Console.WriteLine("mezun olmadiz");
			}
			Console.WriteLine("qiymetlerin ortalamasi");
			return res;
		}
	}
}
