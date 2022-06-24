using System; 
using System.Linq; 
  
 namespace FindCharIndex 
 { 
 	public static class Program 
 	{ 
 		public static void Main() 
 		{
 			string word= Console.ReadLine();
 			char a=Convert.ToChar(Console.ReadLine());
 			
 		    FindCharIndex(word,a);
 		}
 		
 		public static void FindCharIndex(string word, char a)
 		{
 			int x =0;
 			for (var i=0;i<word.Length;i++)
 			{
 				if (word[i]==a)
 				{
 					x=1;
 					Console.WriteLine(i+1 + " herf");
 				}
 				
 				
 			}
 			if(x==0)
 			{
 				Console.WriteLine("yoxdur");
 			}
 			
 			
 			
 		}
 	}
 }