using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Domain.DomainModels.Vegan
{
    public class Tomato : Ingredient
    {
        public Tomato() : base(FoodName.Tomato, FoodType.Vegetable)
        {

        }
    }
}