# ChefM8

Created by Group 8, CPSC 481 (Julia Grab, Victor Dong, Michaela Gilchrist, Kean Arguelles, Junzhi Liu)

This application is a recipe tutorial website created for the company Home Kitchen. Due to the COVID-19 pandemic, Home Kitchen has needed to implement ways to interact with their customers online. This application serves this function by allowing amateur chefs to follow tutorials and access recipes for them to cook.


## How to Run

Click the run button in Visual Studio or type "dotnet watch" into your terminal where the ChefM8 project is located.

This should open the application for you but you can also navigate with your browser to the application at https://localhost:7142/


## Important Notes

There are two accounts already created for the application. These include:
* User 1:
    * Username = adminUser
    * Password = adminPass
* User 2:
    * Username = customerUser
    * Password = customerPass

There are only 3 recipes that have fully functional components (such as being able to see individual recipe page, add to grocery list, etc.). These include:
    - Burger
    - Pancakes
    - Spaghetti


## How to Conduct a Successful Walkthrough

### Login/Registration

1. On startup, click on one of the hearts of a recipe (ex. Burger). This will prompt a popup to inform the user to login. These popup occurs if a user tries to use a feature that requires an account. These features include adding a recipe to favourites, adding to meal plan, and adding to grocery list.
2. Click "Go to Login" in the popup
3. Click the "register" button
4. Click the "register" button without entering any fields. There will be error messages displayed for blank inputs.
5. Try registering with the username "adminUser". Another error message will be displayed saying the username is taken.
6. Fill out the fields with valid information:
    * Ex. Email = john@gmail.com
    * Username = john
    * Password = smith
7. Click the "register" button
8. Click "Have an Account?"
9. Click "Forgot password?"
10. Input email used in registration (ex. john@gmail.com) and click "submit"
11. Click the "Login" tab in the navigation bar
12. Enter login information used in registration:
    * Ex. Username = john
    * Password = smith

### Recipe Browser

13. Under the "Discover" section, type "Burger" into the search bar and hit enter. This will display recipes related to "Burger".
14. Navigate back to the Recipes page through the navigation bar.
15. Use the "Refine Recipes" section on the left side of the Recipes page to filter recipes. Select "Lunch" for Meal and "Easy" for Difficulty.
16. You can either remove the filters by selecting the checkbox again, clicking the black button that relates to a specific filters at the top of the Refine Recipes section, or click the "Clear Filters" button to remove all the filters.
17. After removing all filters, press the heart icon on the "Burger" recipe.
18. Navigate to the Favourites page by using the black button on the right side of the search bar. This will display the recipes added into favourites.

### Recipe

19. Click into the "Burger" recipe.
20. Click on the burger image with the play button, this will open a popup to watch a YouTube tutorial on how to make a burger.
21. Close the video popup.
22. Click the heart icon. This will remove the Burger recipe from the favourites page.
23. Type "2" into the Number of Servings section. The ingredients will be updated to match the amount of servings mentioned.
24. Click the "Voice" button in the bottom right corner. This will be used for voice commands if a user requires hands free interaction with the application.
25. Click the "Add to Meal Plan" button.
26. Select "Su" for Date and "Lunch" for Category. Then click the "Add Recipes" button. This will add the recipe to the meal plan which will be seen later in the walkthrough
27. Click the "Add to Grocery list" button.
28. Click "Add to list". This will add the recipe ingredients to the grocery lsit which will be seen later in the walkthrough.

### Meal Plan

29. Navigate to the Meal Plan page through the navigation bar. The meal plan should currently have a Burger under the Sunday section.
38. Click the "Clear Meal Plan" button to remove all of the recipes in the meal plan.
30. Click the "Add Recipes" button in the bottom right corner.
31. Select the "Pancakes", "Spaghetti", and "Apple Pie" recipe and click "Add Recipes".
32. Click the "Delete" button next to "Apple Pie". This will remove it from the list to add recipes to meal plan.
33. Select "M" for Date and "Breakfast" for Category for the Pancakes recipe. Leave the Spaghetti recipe options blank.
34. Click "Add Recipes". Any recipes added without a date will be put under "Saved Recipes" (ex. Spaghetti) whereas any recipe with a date will be put under its respective section.
35. Click the pencil icon on the "Spaghetti" recipe.
36. Select "Su" for date and "Dinner" for Category. Click "Update Recipe". This will move the recipe to its new date.
37. Click the "Add to Grocery List" button. This will add all of the recipes in meal plan to the grocery list

### Grocery List

38. Navigate to the Grocery list page through the navigation bar. This should display the ingredients added from the recipe page and the meal plan page (Burger, Pancakes, and Spaghetti).
39. Click the "Add Ingredient" button in the top right.
40. Input the following:
    * Ingredient = Strawberries
    * Quantity = 10
    * Units = None (do not select an option)
    * Section = Produce
41. Click "Add Ingredient". There should now be the Strawberries ingredient under the Produce section.
42. Click the "Edit" button next to Strawberries.
43. Change the Quantity to 2 and the Units to "Cup". The Strawberries will be updated on the list.
44. Click the "Delete" button next to Strawberries to remove it from the list.
45. Click the "Clear List" button at the top of the page to remove all of the ingredients.

### Contact Us

46. Navigate to the Contact Us page through the navigation bar. This is a page to allow users to see information about the company Home Kitchen.

### Logout

47. Click the Logout tab in the navigation bar to logout of the user's account.


## Features

### Login/Registration:
* Users can create an account
* Users can login and logout of the application
* Users can get a password reset email if they forgot their password
* Error handling is available for any incorrect inputs (blank fields, already taken usernames)

### Recipe Browser:
* Discover tab to recommend recipes to users
* Search for recipe
* Filter by category
* Ability to add recipes to favourites
* Favourites page to show recipes add to favourites

### Recipe:
* See information about a recipe (Ingredients, Time, Steps)
* Ability to add recipe to favourites
* Add recipe to meal plan
* Add recipe to grocery list
* Adjust amount of servings
* Watch YouTube tutorial video of how to make the recipe
* Voice command available for hands-free use

### Meal Plan:
* Schedule meals for days and meals of the week
* Add recipes to the meal plan
* Edit recipe schedule
* Add meal plan to grocery list
* Clear meal plan

### Grocery List:
* Add ingredients (Name, Quantity, Unit, and Section)
* Edit ingredients (Quantity and Unit)
* Delete ingredients
* Clear grocery list

### Contact Us
* View company information
