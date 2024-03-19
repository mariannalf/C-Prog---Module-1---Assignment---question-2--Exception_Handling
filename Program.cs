using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number between 0 and 255: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 < 0 || num1 > 255)
            {
                throw new ApplicationException("Number must be between 0 and 255.");
            }

            Console.Write("Enter another number between 0 and 255: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num2 < 0 || num2 > 255)
            {
                throw new ApplicationException("Number must be between 0 and 255.");
            }

            int result = num1 / num2;
            Console.WriteLine($"{num1} divided by {num2} is {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter just integer numbers.");
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}