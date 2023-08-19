using System;
class Prac1d3
{
	public static void Main()
	{
		Console.WriteLine("Enter the character = ");
		string ch = Console.ReadLine();
		if(ch.Length == 1)
		{
			if(ch == "a" || ch == "e" || ch == "i" || ch == "o" || ch == "u")
			{
				Console.WriteLine("it is a vowel");
			}else
			{
				Console.WriteLine("it is a not a vowel");
			}
		}else
		{
			Console.WriteLine("Character should be of 1 character");
		}
	}
}
