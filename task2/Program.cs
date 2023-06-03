using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string num = Console.ReadLine();
        try
        {
            Console.WriteLine("Third digit is: " + num[2]);
        }
        
        catch (Exception e)
        {
            Console.WriteLine("Number has no third digit ...");
        }
    }
}