using Catering.Domain.DomainModels;

namespace Catering.Domain.Utils;

public interface IKitchenUtilities
{
    public List<Ingredient> GetDefaultIngredientList();
}