using Catering.Domain.DomainModels;
using Catering.Domain.Utils;

namespace Catering.WebApi.Services;

public class CookingService : ICookingCalculator
{
    private IKitchenUtilities _kitchenUtilities { get; set; }

    public CookingService(IKitchenUtilities kitchenUtilities)
    {
        _kitchenUtilities = kitchenUtilities;
    }
    
    public SetMenu CalculateBestOption()
    {
        var maxPeopleFed = 0;
        var bestCombination = new SetMenu();
        
        var randomSetMenus = _kitchenUtilities.CreatePotentialSetMenus();

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