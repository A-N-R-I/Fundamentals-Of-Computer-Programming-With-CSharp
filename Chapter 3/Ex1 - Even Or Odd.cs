using System;
	
namespace ChapterThreeSolutions
{
    class EvenOrOdd
    {
	static void Main(string[] args)
	{
	    Console.Write("Enter an integer: ");
	    int n = int.Parse(Console.ReadLine());

	    Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
	}
    }
}
