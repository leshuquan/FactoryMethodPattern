using System;
namespace FactoryMethodPattern
{
	/// <summary>
	/// 具体创造者类
	/// </summary>
	public class ChicagoPizzaStore:PizzaStore
	{
		public ChicagoPizzaStore()
		{
		}

		public override Pizza CreatePizza(PizzaType type)
		{
			if (type == PizzaType.Cheeese)
			{
				return new ChicagoCheesePizza();
			}
			else if (type == PizzaType.Pepperoni)
			{
				return new ChicagoPepperoniPizza();
			}
			else if (type == PizzaType.Clam)
			{
				return new ChicagoClamPizza();
			}
			else if (type == PizzaType.Veggie)
			{
				return new ChicagoVeggiePizza();
			}
			else
				return null;
		}
	}
}
