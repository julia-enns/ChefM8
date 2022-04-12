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


    public class SelectedFilter
    {
        public bool IsSelected;
        public Tags Tag;

        public SelectedFilter(Tags tag)
        {
            IsSelected = false;
            Tag = tag;
        }

    }

    public class FilterCategory
    {
        public string Category;
        public List<SelectedFilter> Filters;

        public FilterCategory(string category, List<SelectedFilter> filters)
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

            Filters.Add(new FilterCategory("Meal", new List<SelectedFilter> { new SelectedFilter(Tags.Breakfast), new SelectedFilter(Tags.Lunch), new SelectedFilter(Tags.Dinner), new SelectedFilter(Tags.Dessert) }));
            Filters.Add(new FilterCategory("Difficulty", new List<SelectedFilter> { new SelectedFilter(Tags.Easy), new SelectedFilter(Tags.Medium), new SelectedFilter(Tags.Hard)}));
            Filters.Add(new FilterCategory("Diet", new List<SelectedFilter> { new SelectedFilter(Tags.Meats), new SelectedFilter(Tags.Vegetarian), new SelectedFilter(Tags.Gluten_Free), new SelectedFilter(Tags.Nut_Free), new SelectedFilter(Tags.Keto), new SelectedFilter(Tags.Low_Carb)}));
            Filters.Add(new FilterCategory("Meat", new List<SelectedFilter> { new SelectedFilter(Tags.Beef), new SelectedFilter(Tags.Chicken), new SelectedFilter(Tags.Fish), new SelectedFilter(Tags.Pork)}));
            Filters.Add(new FilterCategory("Ingredient Type", new List<SelectedFilter> { new SelectedFilter(Tags.Meats), new SelectedFilter(Tags.Dairy), new SelectedFilter(Tags.Pasta), new SelectedFilter(Tags.Vegetarian) }));
            Filters.Add(new FilterCategory("Season", new List<SelectedFilter> { new SelectedFilter(Tags.Fall), new SelectedFilter(Tags.Holiday), new SelectedFilter(Tags.Spring), new SelectedFilter(Tags.Summer), new SelectedFilter(Tags.Winter) }));
        }
    }


    public enum MealCategories { Breakfast, Lunch, Dinner, Other }
    public enum Date { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
}