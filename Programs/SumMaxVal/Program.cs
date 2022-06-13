using System;
using System.Linq;

namespace SumMaxVal
{
	public static class Program
	{
	static void Main(string[] args)
	{
		
           int[] a={1,2,3,6,7,8,23,78,34,12};
          
           //int sum=0;
           /*a=Convert.ToInt32(Console.ReadLine());
           
           for (int i=0; i<a.Length; i++){
           sum = sum + a % 10;
           a = a / 10;
           }
           Console.WriteLine(sum);*/
           
           //Console.WriteLine(SumOfArraysItems(a));//1
          
/*int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
int result = 0;
foreach(int number in numbers)
{
    if(number > 0)
    {
        result++;
    }
}
Console.WriteLine($"Число элементов больше нуля: {result}");*/
/*int[] numbers = { -4, -3, -2, -1,0, 1, 2, 3, 4 };
             
int n = numbers.Length; // длина массива
int k = n / 2;          // середина массива
int temp;               // вспомогательный элемент для обмена значениями
for(int i=0; i < k; i++)
{
    temp = numbers[i];
    numbers[i] = numbers[n - i - 1];
    numbers[n - i - 1] = temp;
}
foreach(int i in numbers)
{
    Console.Write($"{i} \t");
}*/
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