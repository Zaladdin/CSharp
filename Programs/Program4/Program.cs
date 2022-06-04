using System;
using System.Linq;

namespace Program4
{
	public static class Program
	{
		public static void Main()
		{
          int a;
          int sum=0;
          int mult=1;
          int b;
          
          a = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"1den {a} qeder ededlerin cemi: ");
          for(int i=0; i<a; i++) 
          {
          	sum+=i;
          	
          	Console.WriteLine(sum);
          }
          Console.WriteLine($"1 den {a} qeder ededlerin hasili: ");
           for(int j=1; j<a; j++) 
          {
          	mult*=j;
          	
          	Console.WriteLine(mult);
          }
          
          b=mult-sum;
          Console.WriteLine($"1den {a} qeder ededlerin hasil ve cemin ferqleri ");
          Console.WriteLine(b);
		}
	}
}