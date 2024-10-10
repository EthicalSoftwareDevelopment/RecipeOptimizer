using Catering.Domain.DomainModels;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.NonVegan;
using Catering.Domain.DomainModels.Recipes;
using Catering.Domain.DomainModels.Vegan;
using Catering.Domain.Extensions;

namespace Catering.Domain.Utils
{

    public class KitchenUtilities : IKitchenUtilities
    {
        public List<KeyValuePair<Ingredient, int>> GetDefaultIngredientList()
        {
            return new List<KeyValuePair<Ingredient, int>>()
            {
                new KeyValuePair<Ingredient, int>(new Cheese(), 8),
                new KeyValuePair<Ingredient, int>(new Cucumber(), 2),
                new KeyValuePair<Ingredient, int>(new Dough(), 10),
                new KeyValuePair<Ingredient, int>(new Lettuce(), 3),
                new KeyValuePair<Ingredient, int>(new Meat(), 6),
                new KeyValuePair<Ingredient, int>(new Olive(), 2),
                new KeyValuePair<Ingredient, int>(new Tomato(), 6)
            };
        }

        public List<Recipe> GetRecipeList()
        {
            return new List<Recipe>()
            {
                new Burger(),
                new Pasta(),
                new Pie(),
                new Pizza(),
                new Salad(),
                new Sandwhich()
            };
        }

        public Recipe GetARandomRecipe()
        {
            var random = new Random();
            var allAvailableRecipes = this.GetRecipeList();

            var randomPossibilities = new List<SetMenu>();
            var nextNumber = random.Next(0, allAvailableRecipes.Count - 1);

            return allAvailableRecipes.ElementAt(nextNumber);
        }
        
        public Recipe GetARandomRecipe(List<Recipe> recipeOptions)
        {
            var random = new Random();

            var randomPossibilities = new List<SetMenu>();
            var nextNumber = random.Next(0, recipeOptions.Count - 1);

            return recipeOptions.ElementAt(nextNumber);
        }

        public SetMenu GetARandomSetMenu(int numberOfRecipes)
        {
            var setMenu = new SetMenu();

            while (numberOfRecipes > 0)
            {
                setMenu.Recipes.Add(this.GetARandomRecipe());

                numberOfRecipes--;
            }

            return setMenu;
        }
        
        public SetMenu GetARandomSetMenu(List<KeyValuePair<Ingredient, int>> remainingIngredients)
        {
            var todaysSetMenu = new SetMenu();
            var staticMenu = this.GetRecipeList();
            var availableRecipes =  staticMenu.Where(x => x.AreRemainingIngredientsEnoughForRecipe(remainingIngredients)).ToList();
            
            var continueCooking = availableRecipes.Count > 0 ? true : false;
            while (continueCooking)
            {
                var useThisRecipe = this.GetARandomRecipe(availableRecipes);
                
                remainingIngredients = useThisRecipe.UseIngredientsForRecipe(remainingIngredients);
                todaysSetMenu.Recipes.Add(useThisRecipe);
                
                availableRecipes = staticMenu.Where(x => x.AreRemainingIngredientsEnoughForRecipe(remainingIngredients)).ToList();
                
                continueCooking = availableRecipes.Count > 0 ? true : false;
            }

            return todaysSetMenu;
        }


        /// <summary>
        /// Gets a Random list of Recipes that potentially maximally utilizes the ingredients.
        /// </summary>
        /// <param name="ingredients"></param>
        /// <returns></returns>
        public SetMenu GetSetMenuFromIngredientConstraints(List<KeyValuePair<Ingredient, int>> ingredients)
        {
            var setMenu = GetARandomSetMenu(ingredients);

            return setMenu;
        }

        public List<SetMenu> GetMultiplePossibilities(List<KeyValuePair<Ingredient, int>> ingredients)
        {
            var result = new List<SetMenu>();
        
            var tries = 10;
        
            for (var i = 0; i < tries; i++)
            {
                var setMenu = GetSetMenuFromIngredientConstraints(ingredients);
        
                result.Add(setMenu);
            }
        
            return result;
        }
    }
}