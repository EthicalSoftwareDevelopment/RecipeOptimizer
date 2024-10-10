using Catering.Domain.DomainModels;
using Catering.Domain.DomainModels.Ingredients;
using Catering.Domain.DomainModels.Vegan;
using Catering.Domain.Utils;
using Catering.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Catering.WebApi.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class CateringController : ControllerBase
    {
        private List<KeyValuePair<Ingredient, int>> _availableIngredients;
        private IKitchenUtilities _kitchenUtilities;
        private ICookingService _cookingService;
        
        private readonly ILogger<CateringController> _logger;

        public CateringController(ILogger<CateringController> logger, IKitchenUtilities kitchenUtilities, ICookingService cookingService)
        {
            _logger = logger;
            this._kitchenUtilities = kitchenUtilities;
            this._availableIngredients = kitchenUtilities.GetDefaultIngredientList();
            this._cookingService = cookingService;
        }

        [HttpGet(Name = "GetARandomSetMenu")]
        public JsonResult GetARandomSetMenu()
        {
            var setMenu = _kitchenUtilities.GetARandomSetMenu(3);

            return new JsonResult(setMenu);
        }

        [HttpGet(Name = "GetBestCombination")]
        public JsonResult GetBestCombination()
        {
            var bestMenuOption = _cookingService.CalculateBestOption(this._availableIngredients);

            return new JsonResult(bestMenuOption);
        }
    }
}