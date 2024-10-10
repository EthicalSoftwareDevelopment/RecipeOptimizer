using Catering.Domain.DomainModels.Enums;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.Vegan;

namespace Catering.Domain.DomainModels.Recipes
{

    public class Pie : Recipe
    {
        public RecipeType RecipeType { get; set; }
        
        private static readonly List<Ingredient> RequiredIngredients = new List<Ingredient>()
        {
            new Dough(),
            new Dough(),
            new Meat(),
            new Meat()
        };

        public Pie() : this(RequiredIngredients)
        {
            this.PeopleFed = 1;
            this.Name = "Pie";
            this.RecipeType = RecipeType.Pie;
        }

        public Pie(List<Ingredient> ingredients) : base(ingredients)
        {
        }
    }
}