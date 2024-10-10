using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Domain.DomainModels.Vegan
{
    public class Olive : Ingredient
    {
        public Olive() : base(FoodName.Olives, FoodType.Vegetable)
        {

        }
    }
}