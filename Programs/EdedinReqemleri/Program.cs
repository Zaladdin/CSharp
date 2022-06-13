using System;
using System.Linq;

namespace Ededinreqemleri
{
    public static class Program
    {
        public static void Main()
        {
            int[] arr={1,2,3,6,7,8,23,78,34,12};
            int val;
            



			

			for (int i=0; i<arr.Length; i++)
			{
				if(arr[i]<9)
				{
					val=arr[i]%10;
			 	    Console.WriteLine(val);
				}
				
				else
				{
					val=arr[i]/10;
					
					Console.WriteLine(val);
					val=arr[i]%10;
					Console.WriteLine(val);
				}
			
				
				
			}
			
        }
    }
}