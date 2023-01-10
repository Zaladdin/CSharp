
using System;

namespace VacancyTask
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = new int[] { 5, 2, 4, 6, 1, 3, 2, 6 };

			Starss();

			Console.WriteLine("Массив A: ");
			foreach (int i in A) Console.Write(i + " ");
			Console.WriteLine();

			Starss();

			A = Sort(A);
			Console.WriteLine("Отсортированный массив: ");
			foreach (int i in A) Console.Write(i + " ");

			Starss();
		}

		public static int[] Sort(int[] Arr)
		{

			if (Arr.Length == 1)
				return Arr;
			else
			{

				int[] Arr1 = new int[Arr.Length / 2];

				int[] Arr2 = new int[Arr.Length - Arr1.Length];

				for (int i = 0; i < Arr.Length; i++)
				{
					if (i < (int)Arr.Length / 2)
						Arr1[i] = Arr[i];
					else
						Arr2[i - (int)Arr.Length / 2] = Arr[i];
				}


				Arr1 = Sort(Arr1);

				Arr2 = Sort(Arr2);

				Arr = SortNext(Arr1, Arr2);
				return Arr;
			}
		}



		public static int[] SortNext(int[] Arr1, int[] Arr2)
		{


			int[] Arr = new int[Arr1.Length + Arr2.Length];
			int x = 0, y = 0;
			for (int i = 0; i < Arr1.Length + Arr2.Length; i++)

			{

				if (y >= Arr2.Length)
				{
					Arr[i] = Arr1[x];
					x++;
				}

				else if (x < Arr1.Length && Arr1[x] < Arr2[y])
				{
					Arr[i] = Arr1[x];
					x++;
				}

				else
				{
					Arr[i] = Arr2[y];
					y++;
				}
			}
			return Arr;
		}

		public static void Starss()
		{
			Console.WriteLine("");
			Console.WriteLine("**************************************");
			Console.WriteLine("");
		}
	}
}