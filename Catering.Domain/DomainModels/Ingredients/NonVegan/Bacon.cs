using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Domain.DomainModels.NonVegan
{

    public class Bacon : Ingredient
    {
        public Bacon() : base(FoodName.Bacon, FoodType.Meat)
        {

        }
    }
}