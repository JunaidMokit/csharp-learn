
using System;
using System.Linq;


class Test
{
    public static void Main(string[] args)
    {



        // Student s1 = new Student();
        // s1.Name = "Junaid";
        // s1.Age = 23;
        // s1.ShowInfo();

        int[] numbers = { 4, 5, 6, 3, 5, 6, 44, 66, 4, 55, 9 };


        var result = from n in numbers
                     where n < 10
                     orderby n
                     select n;

        Console.WriteLine("The numbers are :");

        foreach (var n in result)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Joined:" + string.Join(",", result.ToArray()));


    }


}
