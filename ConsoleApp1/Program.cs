using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        ////(1)
        //Console.WriteLine("EraaSoft520");

        ////(2)
        //Console.WriteLine("Write your Fav number from 1 to 100");
        //int num = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Wow you number {num} is my fav also");

        int NoSmall,NoLarge,PrSmall,PrLarge;

        Console.WriteLine("**** Welcome To Islam's Carpet Cleaning Service ****");
        Console.WriteLine("-----------------------------------------------------");

        Console.Write("Plz enter Number of small carpets: ");
        NoSmall = Convert.ToInt32(Console.ReadLine());

        Console.Write("Plz enter Number of large carpets: ");
        NoLarge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Plz enter Price per small room: ");
        PrSmall = Convert.ToInt32(Console.ReadLine());

        Console.Write("Plz enter Price per large room: ");
        PrLarge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("-------------- Bill Summary ---------------");

        Console.WriteLine($"Number of small carpets: {NoSmall} $");
        Console.WriteLine($"Number of large carpets: {NoLarge} $");
        Console.WriteLine($"Price per small room: {PrSmall} $");
        Console.WriteLine($"Price per large room: {PrLarge} $");
        Console.WriteLine("=============================================");
      
        //Cost
        double cost= NoSmall* PrSmall + NoLarge* PrLarge;
       
        // Tax = 6 %
        double Tax = cost * 0.06;

        double EstCost = cost * 1.06;
        Console.WriteLine($"Cost : {cost.ToString("N2")} $");
        Console.WriteLine($"Tax : 6% -> : {Tax.ToString("N2")} $");
        Console.WriteLine($"Total estimate : {EstCost.ToString("N2")} $");
        Console.WriteLine("This estimate is valid for 30 days");
    }
}
