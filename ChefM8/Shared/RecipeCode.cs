using Blazored.Modal;
using Blazored.Modal.Services;
using ChefM8.Pages.Recipes;
using Microsoft.AspNetCore.Components;

namespace ChefM8.Shared
{
    public abstract class RecipeCode : ComponentBase
    {
        public void AddToFavorites(User user, Recipe recipe)
        {
            MealPlanRecipe newMeal = new MealPlanRecipe(recipe, null, null);
            if (!user.SavedRecipes.Contains(newMeal))
            {
                user.SavedRecipes.Add(newMeal);
            }
        } 
        
        public void showVideoPlayer(IModalService modal, int video)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(VideoPlayer.recipeNumber), video);
            modal.Show<VideoPlayer>("", parameters, new ModalOptions() { Class = "custom-modal" });
        }

        public async void addRecipeToMealplanPopup(IModalService modal, User user, Recipe mealplanRecipe)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(AddToMealPlanPopup.recipe), new SelectedRecipe(new MealPlanRecipe(mealplanRecipe, null, null), true));
            var formModal = modal.Show<AddToMealPlanPopup>("", parameters, new ModalOptions() { Class = "custom-modal" });
            var result = await formModal.Result;

            if (result.Data is null) return;

            foreach (var recipe in (IList<MealPlanRecipe>)result.Data)
            {
                switch (recipe.Date)
                {
                    case Date.Sunday:
                        user.SundayRecipes.Add(recipe);
                        break;
                    case Date.Monday:
                        user.MondayRecipes.Add(recipe);
                        break;
                    case Date.Tuesday:
                        user.TuesdayRecipes.Add(recipe);
                        break;
                    case Date.Wednesday:
                        user.WednesdayRecipes.Add(recipe);
                        break;
                    case Date.Thursday:
                        user.ThursdayRecipes.Add(recipe);
                        break;
                    case Date.Friday:
                        user.FridayRecipes.Add(recipe);
                        break;
                    case Date.Saturday:
                        user.SaturdayRecipes.Add(recipe);
                        break;
                    default:
                        user.SavedRecipes.Add(recipe);
                        break;
                }
            }
        }

        public async void addToGroceryListPopupAsync(IModalService modal, User user, int amount, List<Ingredient> ingredients)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(AddToGroceryListPopup.ingredient), ingredients);
            parameters.Add(nameof(AddToGroceryListPopup.amountFromRecipe), amount);
            var formModal = modal.Show<AddToGroceryListPopup>("", parameters, new ModalOptions() { Class = "custom-modal" });
            var result = await formModal.Result;
            user.Groceries.AddRange((IList<Ingredient>)result.Data);
        }
    }
}