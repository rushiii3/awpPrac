using System;
class Prac1d2
{
	public static void Main()
	{
		
		Console.WriteLine("Enter the number = ");
		int num = Convert.ToInt32(Console.ReadLine());
		int flag = 1;
		for(var i = 2;i<=num/2;i++)
		{
			if(num%i == 0)	
			{
				Console.WriteLine("Not a prime number");
				flag = 0;
				break;
			}
		}
		if(flag == 1)
		{
			Console.WriteLine("it is a prime number");
		}
	}
}
