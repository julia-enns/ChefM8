namespace ChefM8.Shared
{
    public record Recipe(string Name, string Link, MealCategories Category);

    public enum MealCategories { Breakfast, Lunch, Dinner, Other }
}