using System;
using System.Linq;

namespace MaxArr
{
    public static class Program
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 6, 7, 8, 23, 78, 34, 12 };       
            int maxValue = array.Max();
            int maxIndex = array.ToList().IndexOf(maxValue);
            Console.WriteLine(maxValue);
            Console.WriteLine(maxIndex);
        }
    }
}
