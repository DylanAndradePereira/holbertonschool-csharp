using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		percent = percent / currency;
		Console.WriteLine("Percent: {0}",percent);
	}
}