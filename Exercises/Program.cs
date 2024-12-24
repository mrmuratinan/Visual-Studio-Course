using System;
class Program
{
    static void Main()
    {
        int num1 = 43;
        int num2 = 37;
        int num3 = 68;
        int num4 = 54;

        if (num1 < num2)
        {
            Console.WriteLine("Statement 1");
        }
        else if (num1 >= num3)
        {
            Console.WriteLine("Statement 2");
        }
        else if (num3 <= num2)
        {
            Console.WriteLine("Statement 3");
        }
        else if (num1 - num2 <= num3 - num4)
        {
            Console.WriteLine("Statement 4");
        }
        Console.ReadLine();
    }
}

