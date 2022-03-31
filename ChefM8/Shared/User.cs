namespace ChefM8.Shared
{
    public class User
    {
        public IList<MealPlanRecipe> SavedRecipes { get; set; }
        public IList<MealPlanRecipe> SundayRecipes { get; set; }
        public IList<MealPlanRecipe> MondayRecipes { get; set; }
        public IList<MealPlanRecipe> TuesdayRecipes { get; set; }
        public IList<MealPlanRecipe> WednesdayRecipes { get; set; }
        public IList<MealPlanRecipe> ThursdayRecipes { get; set; }
        public IList<MealPlanRecipe> FridayRecipes { get; set; }
        public IList<MealPlanRecipe> SaturdayRecipes { get; set; }

        public User()
        {
            SavedRecipes = new List<MealPlanRecipe>();
            SundayRecipes = new List<MealPlanRecipe>();
            MondayRecipes = new List<MealPlanRecipe>();
            TuesdayRecipes = new List<MealPlanRecipe>();
            WednesdayRecipes = new List<MealPlanRecipe>();
            ThursdayRecipes = new List<MealPlanRecipe>();
            FridayRecipes = new List<MealPlanRecipe>();
            SaturdayRecipes = new List<MealPlanRecipe>();
        }
    }
}