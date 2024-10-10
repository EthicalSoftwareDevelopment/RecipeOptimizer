using System.Text.RegularExpressions;
using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Domain.DomainModels.Recipes
{

    public class Recipe
    {

        #region Properties

        public List<KeyValuePair<Ingredient, int>> Ingredients { get; set; }
        public int PeopleFed { get; set; }

        public string Name { get; set; }

        #endregion

        #region Constructors

        public Recipe()
        {
            
        }
        
        public Recipe(List<Ingredient> ingredients)
        {
            Ingredients = new List<KeyValuePair<Ingredient, int>>();

            var ingredientsGroupedByQuantity = ingredients.GroupBy(x => x)
                .Select(group => new { key = group.Key, count = group.Count() }).ToList();

            foreach (var ingredient in ingredientsGroupedByQuantity)
            {
                Ingredients.Add(new KeyValuePair<Ingredient, int>(ingredient.key, ingredient.count));
            }
        }

        #endregion

        #region Methods



        #endregion
    }
}