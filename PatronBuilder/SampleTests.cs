using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder_Kata2
{
	public static class SampleTests
	{
		public static void Test1()
		{
			var actual = new CoffeeBuilder().SetBlackCoffee().WithSugar("Regular").WithMilk(3.2).Build();
			var expected = new Coffee("Black", new List<Milk> { new Milk(3.2) }, new List<Sugar> { new Sugar("Regular") });
			Console.WriteLine($"expected: {expected}");
			Console.WriteLine($"actual: {actual}");

			bool assertAreEqual = expected.ToString() == actual.ToString();
			Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
		}

		public static void Test2()
		{
			var actual = new CoffeeBuilder().SetAntoccinoCoffee().Build();
			//He cambiado el new Milk de 0.5 a 0.0, que es lo que pone en el enunciado ^^
			var expected = new Coffee("Americano", new List<Milk> { new Milk(0.0) }, new List<Sugar>());
			Console.WriteLine($"expected: {expected}");
			Console.WriteLine($"actual: {actual}");

			bool assertAreEqual = expected.ToString() == actual.ToString();
			Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
		}

		public static void Test3()
		{
			var actual = new CoffeeBuilder().SetCubanoCoffee().Build();
			var expected = new Coffee("Cubano", new List<Milk>(), new List<Sugar> { new Sugar("Brown") });
			Console.WriteLine($"expected: {expected}");
			Console.WriteLine($"actual: {actual}");

			bool assertAreEqual = expected.ToString() == actual.ToString();
			Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
		}
	}
}
