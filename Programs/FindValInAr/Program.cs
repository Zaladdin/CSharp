using System;
using System.Linq;

namespace FindValinArr
{
	public static class Program
	{
		public static void Main()
		{
			int[] ar1={1, 2, 3, 4, 6, 8, 98};
			int a= Convert.ToInt32(Console.ReadLine());
			ValInArr(a,ar1);
		}
		
		public static void ValInArr(int x, int[] arr)
		{
			

			
			for (int i=0; i<arr.Length; i++)
			{
				if(x==arr[i])
				
				   {
				   Console.WriteLine("var " + i + "sirada yerlesen element");
				   	
				   }
				else
				{
					//Console.WriteLine("yox");
				}
				   
				   
				 
				   
				   	
		    }
		    
		    
		    
		}
		
	
	}
}