using System;
using System.Collections.Generic;

namespace FactoryMethodPattern
{
	/// <summary>
	/// 产品类接口
	/// </summary>
	public abstract class Pizza
	{
		protected string name;
		protected string dough;
		protected string sauce;
		protected List<string> toppings = new List<string>();

		public void Prepare()
		{
			Console.WriteLine("Preparing " + name);
			Console.WriteLine("Tossing dough...");
			Console.WriteLine("Ading sauce");
			Console.WriteLine("Adding toppings: ");
			foreach (var item in toppings)
			{
				Console.WriteLine(" " + item);
			}
		}

		public void Bake()
		{
			Console.WriteLine("Bake for 25 minutes at 350");
		}

		public void Cut()
		{
			Console.WriteLine("Cutting the pizza into diagonal slices");
		}

		public void Box()
		{
			Console.WriteLine("Place pizza in official PizzaStore box");
		}

		public string GetName()
		{
			return name;
		}
	}
}

