using System;

namespace FactoryMethodPattern
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			PizzaStore cteator = new NYPizzaStore();
			cteator.orderPizza(PizzaType.Cheeese);
			Console.WriteLine("");
			PizzaStore cteator2 = new ChicagoPizzaStore();
			cteator2.orderPizza(PizzaType.Cheeese);
		}
	}
}
