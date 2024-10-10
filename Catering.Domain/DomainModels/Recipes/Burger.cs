using Catering.Domain.DomainModels.Enums;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.NonVegan;
using Catering.Domain.DomainModels.Vegan;

namespace Catering.Domain.DomainModels.Recipes
{

    public class Burger : Recipe
    {
        public RecipeType RecipeType { get; set; }
        
        private static readonly List<Ingredient> RequiredIngredients = new List<Ingredient>()
        {
            new Meat(),
            new Lettuce(),
            new Tomato(),
            new Cheese(),
            new Dough()
        };

        public Burger() : this(RequiredIngredients)
        {
            this.PeopleFed = 1;
            this.Name = "Burger";
            this.RecipeType = RecipeType.Burger;
        }

        public Burger(List<Ingredient> ingredients) : base(ingredients)
        {
        }
    }
}