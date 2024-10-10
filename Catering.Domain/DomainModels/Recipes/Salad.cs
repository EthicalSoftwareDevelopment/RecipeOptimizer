using Catering.Domain.DomainModels.Enums;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.NonVegan;
using Catering.Domain.DomainModels.Vegan;

namespace Catering.Domain.DomainModels.Recipes
{

    public class Salad : Recipe
    {
        public RecipeType RecipeType { get; set; }
        
        private static readonly List<Ingredient> RequiredIngredients = new List<Ingredient>()
        {
            new Lettuce(),
            new Lettuce(),
            new Tomato(),
            new Tomato(),
            new Cucumber(),
            new Cheese(),
            new Cheese(),
            new Olive()

        };

        public Salad() : this(RequiredIngredients)
        {
            this.PeopleFed = 3;
            this.Name = "Salad";
            this.RecipeType = RecipeType.Salad;
        }

        public Salad(List<Ingredient> ingredients) : base(ingredients)
        {
        }
    }
}