using System;
using System.Linq;

namespace Math.Sqrt
{
	public static class Program
	{
		public static void Main()
		{
			Console.WriteLine(sqrt(49));

		}
		
	
			
			public static double sqrt(double a)
        {
        	a=Convert.ToDouble(Console.ReadLine());
            double t;
            double sqrt = a / 2;
            do
            {
                t = sqrt;
                sqrt = (t + (a / t)) / 2;
            } while ((t - sqrt) != 0);
 
            return sqrt;
        }
		}
	}
