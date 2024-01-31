using ConsoleApp1.Classes;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// new instance
			ExampleClass exampleClass = new ExampleClass();

			// call method
			var result = exampleClass.SumDigits((int)12.5);

			// print result
			Console.WriteLine(result);

			// wait for keypress
			Console.ReadKey();
		}
	}
}