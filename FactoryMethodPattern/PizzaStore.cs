using System;
namespace FactoryMethodPattern
{
	/// <summary>
	/// 比萨枚举
	/// </summary>
	public enum PizzaType
	{
		Cheeese,
		Greek,
		Pepperoni,
		Clam,
		Veggie
	}

	public abstract class PizzaStore
	{
		public PizzaStore()
		{
		}

		public void orderPizza(PizzaType type)
		{
			Pizza pizza;
			pizza = CreatePizza(type);

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();

		}

		/// <summary>
		/// 工厂方法接口
		/// </summary>
		/// <returns>The pizza.</returns>
		/// <param name="type">Type.</param>
		public abstract Pizza CreatePizza(PizzaType type);
	}
}
