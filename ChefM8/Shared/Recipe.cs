namespace ChefM8.Shared
{
    public enum Measurement { Tsp, Tbsp, Cups }
    public enum IngredientCategory { Bakery, Produce, Meats, Dairy, Baking, Other }
    public record Ingredient(string Name, double Amount, Measurement Unit, IngredientCategory Category);

    public record Recipe(string Name, string Link, string Image, List<Ingredient> Ingredients);
    public class MealPlanRecipe {
        public Recipe Recipe;
        public Date? Date;
        public MealCategories? Category;
        public MealPlanRecipe(Recipe recipe, Date? date, MealCategories? category)
        {
            Recipe = recipe;
            Date = date;
            Category = category;
        }
    }

    public class SelectedRecipe
    {
        public MealPlanRecipe Recipe;
        public bool Selected;

        public SelectedRecipe(MealPlanRecipe recipe, bool selected)
        {
            Recipe = recipe;
            Selected = selected;
        }
    }

    public class AllRecipes
    {
        public Recipe Recipe;
        public AllRecipes(Recipe recipe)
        {
            Recipe = recipe;
        }
    }
    public enum MealCategories { Breakfast, Lunch, Dinner, Other }
    public enum Date { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
}