using System;  
public class Equation  
{  
    public static double Factorial(int num)
    {
        if(num==0)
        {
            return 1;
        }
        return num * Factorial(num-1);
            
    }
    public static void Main()
    {
        Console.Write("Enter a number to get the factorial : ");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The factorial is {0}",Factorial(value));
    }
}
