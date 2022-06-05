using System;
using System.Linq;

namespace Program7
{
	public static class Program
	{
		public static void Main()
		{  
			int a;
			
           Console.WriteLine("Yashinizi daxil edin: ");
          a= Convert.ToInt32(Console.ReadLine());
           
           if (0<a&&a<30)
           {
           	Console.WriteLine("Yashini 30a qederdir");
           	Console.WriteLine("Yasinizin kvadrati");
           	Console.WriteLine(a*a);
           }
           else if (a<40 && a>30)
           { 
           	    Console.Write("Yasiniz 30-40 araligindadir");
           	    
           	    Console.WriteLine("Yashinizin son reqemi");
              	Console.WriteLine(a%10);
           }
           
           else 
           {
           	Console.WriteLine("siz heyatda yoxsuz :)");
           }
           
		}
	}
}