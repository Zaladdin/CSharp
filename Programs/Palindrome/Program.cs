using System;
using System.Linq;

namespace Palindrome
{
	public static class Program
	{
		public static void Main()
		{

		string input = Console.ReadLine();

        Console.WriteLine(Palindrome(input));
        
		}
		
		public static string Reverse(string word)
		{
			char[] chars = word.ToCharArray();
			
			for (int i=0; i<word.Length/2;i++)
			{
				char a = chars[i];
				chars[i] =chars[word.Length-i-1];
				chars[word.Length-i-1]=a;
			}
			return new string(chars);
			
			
		}
		
		public static string Palindrome( string x )
		{
		string	y = Reverse(x);
		Console.WriteLine(y);
		
		if (Equals(y, x))
		{
		    
		    return "pal";
		}
		
		else 
		{
		    
		    return"ne pal";
		}    
		
		
		
		    
		    
		
		
		
	
		
		
		}
	}
}