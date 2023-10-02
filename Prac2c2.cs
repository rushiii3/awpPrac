using System;

public class Prac2c2
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 0 || age > 100)
            {
                throw new ArgumentOutOfRangeException("Age", "Age must be between 0 and 120.");
            }
            Console.WriteLine("Your age is: {0}",age);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number for age.");
        }
        catch (ArgumentOutOfRangeException err)
        {
            Console.WriteLine("Invalid age: {0}",err.Message);
        }
        catch (Exception err)
        {
            Console.WriteLine("An error occurred: {0}",err.Message);
        }
        finally{
            Console.WriteLine("Program runned smoothly!");
        }
        
    }
}


// Enter your age:1 200
// Invalid age: Age must be between 0 and 120.
// Parameter name: Age
// Program runned smoothly!
