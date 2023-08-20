using System;
class Prac1d1
{
	public static void Main()
	{
		Console.WriteLine("Enter number = ");
		int num = Convert.ToInt32(Console.ReadLine());
		int num1 = 0;
		int num2 = 1;
		int num3;
		Console.Write(num1+",");
		Console.Write(num2+",");
		for(var i=1;i<=num;i++)
		{	
			num3 = num1+num2;
			Console.Write(num3+",");
			num1 = num2;
			num2 = num3;
		}
	}
}
