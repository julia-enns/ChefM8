namespace ChefM8.Shared
{
    public class User
    {
        public IList<Ingredient> Groceries { get; set; }

        public IList<AvailableRecipes> FavouriteRecipes { get; set; }

        public IList<MealPlanRecipe> SavedRecipes { get; set; }
        public IList<MealPlanRecipe> SundayRecipes { get; set; }
        public IList<MealPlanRecipe> MondayRecipes { get; set; }
        public IList<MealPlanRecipe> TuesdayRecipes { get; set; }
        public IList<MealPlanRecipe> WednesdayRecipes { get; set; }
        public IList<MealPlanRecipe> ThursdayRecipes { get; set; }
        public IList<MealPlanRecipe> FridayRecipes { get; set; }
        public IList<MealPlanRecipe> SaturdayRecipes { get; set; }
        
        public List<string> Usernames { get; set; }
        public List<string> Passwords { get; set; }

        public User()
        {
            Groceries = new List<Ingredient>() {
                new Ingredient("Ground beef", 1, Measurement.Pound, IngredientCategory.Meats),
                new Ingredient("Dried spaghetti", 2, Measurement.Ounce, IngredientCategory.Other),
                new Ingredient("Shredded parmesan cheese", 1, Measurement.Cup, IngredientCategory.Dairy),
                new Ingredient("Tomato paste", 1, Measurement.Tbsp, IngredientCategory.Other),
                new Ingredient("Can crushed tomatoes", 1, Measurement.None, IngredientCategory.Other),
                new Ingredient("Garlic cloves", 1, Measurement.None, IngredientCategory.Produce),
                new Ingredient("Olive oil", 3, Measurement.Tbsp, IngredientCategory.Other),
                new Ingredient("Salt", 1, Measurement.Tsp, IngredientCategory.Other),
                new Ingredient("Pepper", 1, Measurement.Tsp, IngredientCategory.Other)
                };

            FavouriteRecipes = new List<AvailableRecipes>();

            SavedRecipes = new List<MealPlanRecipe>();
            SundayRecipes = new List<MealPlanRecipe>();
            MondayRecipes = new List<MealPlanRecipe>();
            TuesdayRecipes = new List<MealPlanRecipe>();
            WednesdayRecipes = new List<MealPlanRecipe>();
            ThursdayRecipes = new List<MealPlanRecipe>();
            FridayRecipes = new List<MealPlanRecipe>();
            SaturdayRecipes = new List<MealPlanRecipe>();

            Usernames = new List<string>();
            Passwords = new List<string>();


        }
    }
}