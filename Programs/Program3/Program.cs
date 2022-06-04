using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold
{
    public static class Program 
    {         
        public static void Main()
        {
            int a;
            int sum;
            sum =0;
           
          a = Convert.ToInt32(Console.ReadLine()) ;
            for( int i=1; i<=a; i++){
            	
            	sum += i*i;
            	
            	Console.WriteLine(sum);
            }
        }
    }
}