using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string num = Console.ReadLine();
        
        Console.WriteLine("Second digit is: " + num[1]);
    }
}