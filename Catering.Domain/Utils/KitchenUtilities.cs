using Catering.Domain.DomainModels;

namespace Catering.Domain.Utils;

public class KitchenUtilities
{
    public List<Ingredient> GetDefaultIngredientList()
    {
        return new List<Ingredient>()
        {
            new Cucumber(),
            new Cucumber(),
            new Cheese(),
            new Meat()
        };
    }
}