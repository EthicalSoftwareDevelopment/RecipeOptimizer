using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Domain.DomainModels.Vegan
{
    public class Dough : Ingredient
    {
        public Dough() : base(FoodName.Dough, FoodType.Gluten)
        {

        }
    }
}