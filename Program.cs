using System;
using static ConsoleApp1.Class1;

namespace TestProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello");
			HelloInProgram.Hello();
			Hello();
			Console.ReadKey();
			
		}
	}

	class HelloInProgram
	{
		public static void Hello()//public makes it visible/usable to outside its class
		{
			Console.WriteLine("Hello1");
		}
	}
}