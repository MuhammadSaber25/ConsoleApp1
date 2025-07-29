namespace MultiplicationTask;

internal class Program
{
    static void Main(string[] args)
    {
        //Grade Checker
        //Console.Write("enter a mark (0–100) :");
        //int grade = Convert.ToInt32(Console.ReadLine());

        //if (grade >= 90 && grade <= 100)
        //{
        //    Console.WriteLine("Your grade is A");
        //}
        //else if (grade >= 80 && grade <= 89)
        //{
        //    Console.WriteLine("Your grade is B");
        //}
        //else if (grade >= 70 && grade <= 79)
        //{
        //    Console.WriteLine("Your grade is C");
        //}
        //else if (grade >= 60 && grade <= 69)
        //{
        //    Console.WriteLine("Your grade is D");
        //}
        //else
        //{
        //    Console.WriteLine("Your grade is F");
        //}

        //Multiplication Table
        Console.Write("Enter a number to print its multiplication table: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i <= 12)
        {
            Console.WriteLine($"{x}x{i} = {i * x}");
            i++;
        }
    }
}
