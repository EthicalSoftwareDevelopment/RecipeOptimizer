using Catering.Domain.DomainModels.Enums;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.NonVegan;
using Catering.Domain.DomainModels.Vegan;

namespace Catering.Domain.DomainModels.Recipes
{

    public class Pasta : Recipe
    {
        public RecipeType RecipeType { get; set; }
        
        private static readonly List<Ingredient> RequiredIngredients = new List<Ingredient>()
        {
            new Dough(),
            new Dough(),
            new Tomato(),
            new Cheese(),
            new Cheese(),
            new Meat()
        };

        public Pasta() : this(RequiredIngredients)
        {
            this.PeopleFed = 2;
            this.Name = "Pasta";
            this.RecipeType = RecipeType.Pasta;
        }

        public Pasta(List<Ingredient> ingredients) : base(ingredients)
        {
        }
    }
}