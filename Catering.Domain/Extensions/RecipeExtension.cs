using System.Collections;
using System.Text.RegularExpressions;
using Catering.Domain.DomainModels;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.Recipes;

namespace Catering.Domain.Extensions
{

    public static class RecipeExtension
    {
        /// <param name="recipe"></param>
        /// <param name="remainingIngredients">Ingredient, Quantity</param>
        /// <returns></returns>
        public static bool AreRemainingIngredientsEnoughForRecipe(this Recipe recipe,
            List<KeyValuePair<Ingredient, int>> remainingIngredients)
        {
            var groupedIngredientsByCount = remainingIngredients.GroupBy(x => x.Key);
                //.Select(group => new { ingredient = group.Key, count = group.Count() });

            foreach (var requiredIngredient in recipe.Ingredients)
            {
                var sufficientQuantityOfThisItem = groupedIngredientsByCount.Any(x => 
                    x.Key.Name == requiredIngredient.Key.Name 
                    && x.First().Value >= requiredIngredient.Value);
                
                if (sufficientQuantityOfThisItem)
                {

                }
                else
                {
                    return false;
                }
            }

            return true;
        }
        

        /// <summary>
        /// Returns Ingredients list after consumption
        /// </summary>
        /// <param name="recipe"></param>
        /// <param name="remainingIngredients"></param>
        /// <returns></returns>
        public static List<KeyValuePair<Ingredient, int>> UseIngredientsForRecipe(this Recipe recipe,
            List<KeyValuePair<Ingredient, int>> remainingIngredients)
        {
            var remainingIngredientsAsArray = remainingIngredients.ToArray();

            foreach (var requiredIngredient in recipe.Ingredients)
            {
                for (var i = 0; i < remainingIngredientsAsArray.Length; i++)
                {
                    if (remainingIngredientsAsArray[i].Key.Name == requiredIngredient.Key.Name)
                    {
                        var leftOverIngredients = SubtractAnIngredient(remainingIngredientsAsArray, i);
                        remainingIngredientsAsArray[i] = leftOverIngredients;
                    }
                }
            }

            return remainingIngredientsAsArray.ToList();
        }

        private static KeyValuePair<Ingredient, int> SubtractAnIngredient(KeyValuePair<Ingredient, int>[] remainingIngredientsAsArray, int i)
        {
            var tempClone =
                new KeyValuePair<Ingredient, int>(remainingIngredientsAsArray[i].Key, remainingIngredientsAsArray[i].Value - 1);
            return tempClone;
        }
    }
}