using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.NonVegan;
using Catering.Domain.DomainModels.Recipes;
using Catering.Domain.DomainModels.Vegan;

namespace Catering.Domain.Builders
{

    public class BurgerBuilder
    {
        private Burger _burger = new Burger();

        public BurgerBuilder Standard()
        {
            return this;
        }

        public BurgerBuilder WithExtraPatty()
        {
            _burger.Ingredients.Add(new KeyValuePair<Ingredient, int>(new Meat(), 1));
            return this;
        }

        public BurgerBuilder WithExtraCheese()
        {
            _burger.Ingredients.Add(new KeyValuePair<Ingredient, int>(new Cheese(), 1));
            return this;
        }

        public BurgerBuilder WithBacon()
        {
            _burger.Ingredients.Add(new KeyValuePair<Ingredient, int>(new Bacon(), 1));
            return this;
        }

        public Burger Build()
        {
            return _burger;
        }
    }
}