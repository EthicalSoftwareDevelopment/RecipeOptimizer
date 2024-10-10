using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Domain.DomainModels.Vegan
{
    public class Cucumber : Ingredient
    {
        public Cucumber() : base(FoodName.Cucumber, FoodType.Vegetable)
        {

        }
    }
}