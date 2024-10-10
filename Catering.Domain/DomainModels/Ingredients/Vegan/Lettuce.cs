using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Domain.DomainModels.Vegan
{
    public class Lettuce : Ingredient
    {
        public Lettuce() : base(FoodName.Lettuce, FoodType.Vegetable)
        {

        }
    }
}