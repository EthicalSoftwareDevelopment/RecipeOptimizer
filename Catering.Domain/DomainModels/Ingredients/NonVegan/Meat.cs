using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Domain.DomainModels.Vegan
{

    public class Meat : Ingredient
    {
        public Meat() : base(FoodName.Meat, FoodType.Meat)
        {

        }
    }
}