
using System;

class Test
{
    public static void Main(string[] args)
    {

        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;

        Console.WriteLine("Sum=" + sum);

        if (sum > 5)
        {
            Console.WriteLine("This is a good number");

        }
        else if (sum > 7)
        {
            Console.WriteLine("This is a good number");
        }
        else
        {
            Console.WriteLine("This is bad number");
        }

        switch (sum)
        {
            case int n when n > 7:
                Console.WriteLine("This is a good number");
                break;

            case int n when n > 5:
                Console.WriteLine("This is a moderate number");
                break;

            default:
                Console.WriteLine("This is Bad Number");
                break;


        }

    }
}
