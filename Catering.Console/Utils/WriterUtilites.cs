using Catering.Console.Utils.Interfaces;
using Catering.Domain.DomainModels;
using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Console.Utils
{

    public class WriterUtilities : IWriterUtilities
    {
        public void WriteIngredients(List<KeyValuePair<Ingredient, int>> ingredients)
        {
            foreach (var ingredient in ingredients.GroupBy(x => x.Key.Name))
            {
                System.Console.WriteLine(ingredient.Key + ": " + ingredient.Sum(y=>y.Value));
            }
        }

        public void WriteSetMenu(SetMenu bestCookingOption)
        {
            System.Console.WriteLine("Optimal amount of People fed: " + bestCookingOption.Recipes.Sum(x=>x.PeopleFed));// feeding how many people
            
            foreach (var recipe in bestCookingOption.Recipes)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(recipe + ": " + recipe.Name);
                System.Console.Write("Ingredients: "); 
                WriteIngredients(recipe.Ingredients);
            }
        }
    }
}