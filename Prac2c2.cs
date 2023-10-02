using System;

public class Prac2c2
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            string userInput = Console.ReadLine();
            int userAge = int.Parse(userInput);
            if (userAge <= 0 || userAge > 100)
            {
                throw new ArgumentOutOfRangeException("Age", "Age must be between 0 and 120.");
            }
            Console.WriteLine($"Your age is: {userAge}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number for age.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Invalid age: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        Console.WriteLine("Program runned smoothly!");
    }
}


// Enter your age:1 200
// Invalid age: Age must be between 0 and 120.
// Parameter name: Age
// Program runned smoothly!
