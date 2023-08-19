using System;
class PracOneA
{
	public static void Main()
	{
		Console.WriteLine("This is Practical 1 A");

		Console.WriteLine("Enter Integer 1 = ");
		int numb1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Integer 2 = ");
		int numb2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter Integer 3 = ");
		int numb3 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Integer 4 = ");
		int numb4 = Convert.ToInt32(Console.ReadLine());


		int product = numb1 * numb2 * numb3 * numb4;

		Console.WriteLine("The product of 4 int values are "+product);
	}
}