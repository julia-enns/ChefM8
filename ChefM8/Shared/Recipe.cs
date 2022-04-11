namespace ChefM8.Shared
{
    public enum Measurement { None, Tsp, Tbsp, Cup, Piece, Slice, Pound, Ounce }
    public enum IngredientCategory { None, Bakery, Produce, Meats, Dairy, Baking, Other }
    public record Ingredient(string Name, double Amount, Measurement Unit, IngredientCategory Category);
    // anything after "hard" are fillers
    public enum Tags { Bakery, Produce, Pasta, Meats, Dairy, Baking, Beef, Vegetarian, Breakfast, Lunch, Dinner, Dessert, Easy, Medium, Hard, Gluten_Free, Low_Carb, Keto, Nut_Free,
        Chicken,
        Fish,
        Pork,
        Fall,
        Holiday,
        Spring,
        Summer,
        Winter
    }
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

    // Recipes that are functional and can be clicked
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

    public class FilterCategory
    {
        public string Category;
        public List<Tags> Filters;

        // constructor populates the list of display reci
        public FilterCategory(string category, List<Tags> filters)
        {
            Category = category;
            Filters = filters;
        }
    }

    public class AllFilters
    {
        public List<FilterCategory> Filters;

        public AllFilters()
        {
            Filters = new List<FilterCategory>();

            Filters.Add(new FilterCategory("Meal", new List<Tags> { Tags.Breakfast, Tags.Lunch, Tags.Dinner, Tags.Dessert }));
            Filters.Add(new FilterCategory("Difficulty", new List<Tags> { Tags.Easy, Tags.Medium, Tags.Hard}));
            Filters.Add(new FilterCategory("Diet", new List<Tags> { Tags.Meats, Tags.Vegetarian, Tags.Gluten_Free, Tags.Nut_Free, Tags.Keto, Tags.Low_Carb}));
            Filters.Add(new FilterCategory("Meat", new List<Tags> { Tags.Beef, Tags.Chicken, Tags.Fish, Tags.Pork}));
            Filters.Add(new FilterCategory("Ingredient Type", new List<Tags> { Tags.Meats, Tags.Dairy, Tags.Pasta, Tags.Vegetarian }));
            Filters.Add(new FilterCategory("Season", new List<Tags> { Tags.Fall, Tags.Holiday, Tags.Spring, Tags.Summer, Tags.Winter }));
        }
    }


    public enum MealCategories { Breakfast, Lunch, Dinner, Other }
    public enum Date { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
}