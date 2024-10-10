using Catering.Domain.DomainModels.Enums;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.Vegan;

namespace Catering.Domain.DomainModels.Recipes
{

    public class Sandwhich : Recipe
    {
        public RecipeType RecipeType { get; set; }
        
        private static readonly List<Ingredient> RequiredIngredients = new List<Ingredient>()
        {
            new Dough(),
            new Cucumber()
        };

        public Sandwhich() : this(RequiredIngredients)
        {
            this.PeopleFed = 1;
            this.Name = "Sandwhich";
            this.RecipeType = RecipeType.Sandwhich;
        }

        public Sandwhich(List<Ingredient> ingredients) : base(ingredients)
        {
        }
    }
}