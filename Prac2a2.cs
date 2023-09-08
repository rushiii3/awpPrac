using System;  
public class Equation  
{  
    public static double MoneyConversion(int num)
    {
        return num * 83.01;
    }
    public static void Main()
    {
        Console.Write("Enter Indian currency to convert into US dollars : ");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The US Dollars is ${0}",MoneyConversion(value));
    }
}

/*
Enter Indian currency to convert into US dollars : 20
The US Dollars is $1660.2
*/
