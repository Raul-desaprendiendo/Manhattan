using System;
using System.Collections.Generic;
using System.Linq;

namespace PatronBuilder_Kata2
{

	/// <summary>
	/// METODO TOSTRING:
	/// Se sobre carga el método toString básicamente para poder mostrar lo que nosotros queremos,
	/// si no se sobrecarga y se edita, se pinta o bien la direccion de memoria, o el nombre del obj.
	/// 
	/// 
	/// PATRONES PARECIDO:
	/// Factory Comparison y Prototype.
	/// Se parece bastante la forma de aplicar el patron, puesto que se ramifican para distintos usos.
	/// </summary>
	internal class Program
	{
		private static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine(@"
					To run tests write:
					testAll
					test1
					test2
					test3
					");
				var instrucction = Console.ReadLine();
				if (instrucction == "testAll")
				{
					SampleTests.Test1();
					SampleTests.Test2();
					SampleTests.Test3();
				}
				else if (instrucction == "test1")
					SampleTests.Test1();
				else if (instrucction == "test2")
					SampleTests.Test2();
				else if (instrucction == "test3")
					SampleTests.Test3();
				}
		}

		
	}
}