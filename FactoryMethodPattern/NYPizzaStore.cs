using System;
namespace FactoryMethodPattern
{
	/// <summary>
	/// 具体创建者类
	/// </summary>
	public class NYPizzaStore:PizzaStore
	{
		public NYPizzaStore()
		{
		}

		/// <summary>
		/// 具体工厂方法
		/// </summary>
		/// <returns>The pizza.</returns>
		/// <param name="type">Type.</param>
		public override Pizza CreatePizza(PizzaType type)
		{
			if (type == PizzaType.Cheeese) {
				return new NYCheesePizza();
			} else if (type == PizzaType.Pepperoni) {
				return new NYPepperoniPizza();
			} else if (type == PizzaType.Clam) {
				return new NYClamPizza();
			} else if (type == PizzaType.Veggie) {
				return new NYVeggiePizza();
			} else
				return null;
		}
	}
}
