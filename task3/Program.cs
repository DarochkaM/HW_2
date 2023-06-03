using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a digit:");
        string strnum = Console.ReadLine();
        int num = int.Parse(strnum);
        if (num==6) 
        {
            Console.WriteLine("Yes, it is a holiday");
        }
        else if (num==7)
        {
            Console.WriteLine("Yes, it is a holiday");
        }
        else
        {
            Console.WriteLine("No, it is not a holiday");
        }
    }
}