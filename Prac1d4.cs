using System;
class Prac1d1
{
	public static void Main()
	{
		Console.WriteLine("Enter number = ");
		int num = Convert.ToInt32(Console.ReadLine());
		int sum=0;
		int rem,rev=0;
		while(num!=0)
		{
		    rem = num%10;
		    rev = rev*10 + rem;
		    num = num/10;
		    sum = sum + rem ;
		}
		Console.WriteLine("Revese is "+rev);
		Console.WriteLine(sum);
	}
}
