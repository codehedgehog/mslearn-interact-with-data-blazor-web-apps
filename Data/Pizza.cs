namespace BlazingPizza.Data
{
	public class Pizza
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "You must set a name for your pizza.")]
		public string Name { get; set; }

		public string Description { get; set; }

		[EmailAddress(ErrorMessage = "You must set a valid email address for the chef responsible for the pizza recipe.")]
		public string ChefEmail { get; set; }

		[Required]
		[Range(10.00, 25.00, ErrorMessage = "You must set a price between $10 and $25.")]
		public decimal Price { get; set; }

		public bool Vegetarian { get; set; }

		public bool Vegan { get; set; }

		[PizzaBase]
		public string Base { get; set; }
	}

	public class PizzaService
	{
		public Task<Pizza[]> GetPizzasAsync()
		{
			return Task.FromResult(new Pizza[] {
				new Pizza() { Id = 1, Name = "Margherita", Vegetarian = false, Vegan = false, Price = 14 },
				new Pizza() { Id = 2, Name = "Hawaiian", Vegetarian = false, Vegan = false, Price = 11 },
				new Pizza() { Id = 3, Name = "Fiorentina", Vegetarian = false, Vegan = false, Price = 10 },
				new Pizza() { Id = 4, Name = "Italiano", Vegetarian = false, Vegan = false, Price = 12 },
				new Pizza() { Id = 5, Name = "Pepperoni", Vegetarian = false, Vegan = false, Price = 14 },
			});
		}
	}

	public class PizzaBase : ValidationAttribute
	{
		public string GetErrorMessage() => $"Sorry, that's not a valid pizza base.";

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (Convert.ToString(value) != "Tomato" || Convert.ToString(value) != "Pesto")
				return new ValidationResult(GetErrorMessage());
			return ValidationResult.Success;
		}
	}
}