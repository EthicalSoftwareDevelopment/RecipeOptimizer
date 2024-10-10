using Catering.Domain.DomainModels;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.Utils;

namespace Catering.WebApi.Services;

public class CookingService : ICookingService
{
    private IKitchenUtilities _kitchenUtilities { get; set; }

    public CookingService(IKitchenUtilities kitchenUtilities)
    {
        this._kitchenUtilities = kitchenUtilities;
    }
    
    public SetMenu CalculateBestOption(List<KeyValuePair<Ingredient,int>> ingredients)
    {
        var bestCombination = new SetMenu();
        
        var randomSetMenus = _kitchenUtilities.GetMultiplePossibilities(ingredients);

        return BestRecipeCombination(randomSetMenus);
    }

    private static SetMenu BestRecipeCombination(List<SetMenu> randomSetMenus)
    {
        var maxPeopleFed = 0; 
        var bestCombination = new SetMenu();
        
        foreach (var setMenu in randomSetMenus)
        {
            var sumOfTotalPeopleFedByMenu = setMenu.Recipes.Sum(x => x.PeopleFed);
            if (sumOfTotalPeopleFedByMenu > maxPeopleFed)
            {
                maxPeopleFed = sumOfTotalPeopleFedByMenu;
                bestCombination = setMenu;
            }
        }

        return bestCombination;
    }
}