using System;
namespace FactoryMethodPattern
{
	/// <summary>
	/// 具体产品类
	/// </summary>
	public class NYCheesePizza:Pizza
	{
		public NYCheesePizza()
		{
            this.name = "NY Style Suce and Cheese Pizza";
			this.dough = "Thin Crust Dough";
			this.sauce = "Marinara Sauce";
			this.toppings.Add ("Grated Reggiano Cheese");
		}
	}
}
