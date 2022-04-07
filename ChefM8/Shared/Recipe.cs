namespace ChefM8.Shared
{
    public enum Measurement { None, Tsp, Tbsp, Cup, Piece, Slice, Pound, Ounce }
    public enum IngredientCategory { None, Bakery, Produce, Meats, Dairy, Baking, Other }
    public record Ingredient(string Name, double Amount, Measurement Unit, IngredientCategory Category);
    public enum Tags { Bakery, Produce, Pasta, Meats, Dairy, Baking, Beef, Vegetarian, Breakfast, Lunch, Dinner, Easy, Medium, Hard};

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

    // Available recipes that would show up in the homepage
    public class AvailableRecipes
    {
        public Recipe Recipe;
        public List<Tags> Tags;
        public string Description;
        public string Duration;

        public AvailableRecipes(Recipe recipe, List<Tags> tags, string desc, string duration)
        {
            Recipe = recipe;
            Tags = tags;
            Description = desc;
            Duration = duration;
        }
    }

    public enum MealCategories { Breakfast, Lunch, Dinner, Other }
    public enum Date { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
}