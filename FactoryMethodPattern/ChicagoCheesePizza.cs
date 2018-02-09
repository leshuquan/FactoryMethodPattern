using System;
namespace FactoryMethodPattern
{
	public class ChicagoCheesePizza:Pizza
	{
		public ChicagoCheesePizza()
		{
            this.name = "Chicago Style Suce and Cheese Pizza";
			this.dough = "Thin Crust Dough";
			this.sauce = "Marinara Sauce";
			this.toppings.Add ("Grated Reggiano Cheese");
		}
	}
}
