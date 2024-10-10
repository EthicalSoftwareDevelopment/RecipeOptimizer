using Catering.Domain.DomainModels;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.Recipes;

namespace Catering.Domain.Utils
{

    public interface IKitchenUtilities
    {
        /// <returns>Ingredient, Quantity</returns>
        public List<KeyValuePair<Ingredient, int>> GetDefaultIngredientList();

        public List<Recipe> GetRecipeList();

        public Recipe GetARandomRecipe();

        public SetMenu GetARandomSetMenu(int numberOfRecipes);

        /// <param name="numberOfRecipes"></param>
        /// <param name="ingredients">Ingredients, Quantity</param>
        /// <returns>SetMenu - List of Recipes</returns>
        public SetMenu GetSetMenuFromIngredientConstraints(List<KeyValuePair<Ingredient, int>> ingredients);
        
        
        public List<SetMenu> GetMultiplePossibilities(List<KeyValuePair<Ingredient, int>> ingredients);
    }
}