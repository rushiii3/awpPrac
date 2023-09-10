// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Prac2a4
{
    public static int cTof(int num)
    {
        int calculate = ((num * 9/5) + 32);
        return calculate;
    }
    public static decimal fToc(int num)
    {
        decimal calculate = ((num - 32) * 5/9);
        return calculate;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter 1 for celcius to farenheit and 2 for farenheit to celcius : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if(choice==1){
            Console.Write("Enter values for conversion : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine (cTof(value)+" C");
        }else if(choice==2){
            Console.Write("Enter values for conversion : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine (fToc(value)+" F");
        }else{
            Console.WriteLine ("Please enter a valid number");
        }
    }
}

//output
// Enter 1 for celcius to farenheit and 2 for farenheit to celcius : 1
// Enter values for conversion : 37
// 98 C
