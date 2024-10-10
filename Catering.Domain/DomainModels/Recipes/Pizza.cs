using Catering.Domain.DomainModels.Enums;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.NonVegan;
using Catering.Domain.DomainModels.Vegan;

namespace Catering.Domain.DomainModels.Recipes
{

    public class Pizza : Recipe
    {
        public RecipeType RecipeType { get; set; }
        
        private static readonly List<Ingredient> RequiredIngredients = new List<Ingredient>()
        {
            new Dough(),
            new Dough(),
            new Dough(),
            new Tomato(),
            new Tomato(),
            new Cheese(),
            new Cheese(),
            new Cheese(),
            new Olive()
        };

        public Pizza() : this(RequiredIngredients)
        {
            this.PeopleFed = 4;
            this.Name = "Pizza";
            this.RecipeType = RecipeType.Pizza;
        }

        public Pizza(List<Ingredient> ingredients) : base(ingredients)
        {
        }
    }
}