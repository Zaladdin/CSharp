using System;
using System.Linq;

namespace SumMaxVal
{
	public static class Program
	{
	static void Main(string[] args)
	{
		
           int[] a={1,2,3,6,7,8,23,78,34,12};
          
           
            int temp;
for (int i = 0; i < a.Length - 1; i++)
{
    for (int j = i + 1; j < a.Length; j++)
    {
        if (a[i] > a[j])
        {
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
 
// вывод
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}
          
		}
	}
}
