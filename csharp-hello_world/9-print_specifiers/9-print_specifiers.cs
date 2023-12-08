using System;
using System.Globalization;
class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("Percent: {0}",String.Format("Value: {0:P2}.", percent));
		Console.WriteLine("Currency: {0}",currency.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
	}
}