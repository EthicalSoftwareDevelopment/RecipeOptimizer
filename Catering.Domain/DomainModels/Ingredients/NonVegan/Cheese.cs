using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Domain.DomainModels.NonVegan
{

    public class Cheese : Ingredient
    {
        public Cheese() : base(FoodName.Cheese, FoodType.Dairy)
        {

        }
    }
}