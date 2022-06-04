using System;
using System.Linq;

namespace Program5
{
	public static class Program
	{
		public static void Main()
		{
		
         int a;
         int x;
         int y;
         int z;
         int t;
         int sum;
         a=Convert.ToInt32(Console.ReadLine());
         x=a/1000;
        
         Console.WriteLine(x);
         
         y=(a-x*1000)/100;
         Console.WriteLine(y);
         z=(a-x*1000-y*100)/10;
         Console.WriteLine(z);
         t=(a-x*1000-y*100-z*10);
         Console.WriteLine(t);
         sum=x+y+z+t;
         Console.WriteLine(sum);
	}
}
}