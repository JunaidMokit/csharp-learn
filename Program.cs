
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
            // Console.Write(n + " ");
        }

        var result2 = numbers.Where(n => n < 10)
                             .OrderBy(n => n)
                             .Select(n => n);
        foreach (var n in result2)
        {
            // Console.Write(n + " ");

        }

        string[] names = { "Junaid", "Rahman", "Mokit", "Ali" };

        var result3 = names.Where(name => name.StartsWith("M"));
        var result4 = names.Where(name => name.EndsWith("d"));
        foreach (var n in result4)
        {
            // Console.WriteLine(n);
        }

        string[] namesAll = { "Ali", "Anik", "Babul", "Bashir", "Mokit" };

        var groups = from n in namesAll
                     group n by n[0];
        foreach (var g in groups)
        {
            Console.WriteLine($"Group {g.Key}");
            foreach (var name in g)
            {
                Console.WriteLine(" " + name);
            }
        }




    }


}
