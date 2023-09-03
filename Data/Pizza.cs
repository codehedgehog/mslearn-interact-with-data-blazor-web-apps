namespace BlazingPizza.Data
{
	public class Pizza
	{
		public int PizzaId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public bool Vegetarian { get; set; }
		public bool Vegan { get; set; }
	}

	public class PizzaService
	{
		public Task<Pizza[]> GetPizzasAsync()
		{
			return Task.FromResult(new Pizza[] {
				new Pizza() { PizzaId = 1, Name = "Margherita", Vegetarian = false, Vegan = false, Price = 14 },
				new Pizza() { PizzaId = 2, Name = "Hawaiian", Vegetarian = false, Vegan = false, Price = 11 },
				new Pizza() { PizzaId = 3, Name = "Fiorentina", Vegetarian = false, Vegan = false, Price = 10 },
				new Pizza() { PizzaId = 4, Name = "Italiano", Vegetarian = false, Vegan = false, Price = 12 },
				new Pizza() { PizzaId = 5, Name = "Pepperoni", Vegetarian = false, Vegan = false, Price = 14 },
			});
		}
	}
}