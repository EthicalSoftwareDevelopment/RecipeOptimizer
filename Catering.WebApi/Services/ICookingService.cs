using Catering.Domain.DomainModels;
using Catering.Domain.DomainModels.Ingredients;

namespace Catering.WebApi.Services;

public interface ICookingService
{
    public SetMenu CalculateBestOption(List<KeyValuePair<Ingredient,int>> ingredients);
}