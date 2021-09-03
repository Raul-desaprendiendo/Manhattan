using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder_Kata2
{
	class CoffeeBuilder
	{
		public string _Type;
		public List<Milk> _ListMilk;
		public List<Sugar> _ListSugar;


		public CoffeeBuilder()
		{
			_ListMilk = new List<Milk>();
			_ListSugar = new List<Sugar>();
		}

		public CoffeeBuilder SetBlackCoffee()
		{
			_Type = "Black";
			return this;
		}
		public CoffeeBuilder SetCubanoCoffee()
		{
			_Type = "Cubano";
			_ListSugar.Add(new Sugar("Brown"));
			return this;
		}
		public CoffeeBuilder SetAntoccinoCoffee()
		{
			_Type = "Americano";
			_ListMilk.Add(new Milk(0.0));
			return this;
		}

		public CoffeeBuilder WithMilk(double fat)
		{
			_ListMilk.Add(new Milk(fat));
			return this;
		}
		public CoffeeBuilder WithSugar(string sort)
		{
			_ListSugar.Add(new Sugar(sort));
			return this;
		}

		public Coffee Build() { return new Coffee(_Type, _ListMilk, _ListSugar); }
	};
}
