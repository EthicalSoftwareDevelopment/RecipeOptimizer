using Catering.Domain.DomainModels.Enums;

namespace Catering.Domain.DomainModels.Ingredients;

public class Ingredient
{
    #region Properties
    
    public FoodName Name { get; set; }
    
    public FoodType FoodType { get; set; }
    
    #endregion
    
    #region Constructors

    public Ingredient()
    {
        FoodType = FoodType.Unknown;
    }
    
    public Ingredient(FoodName foodName, FoodType foodType)
    {
        Name = foodName;
        FoodType = foodType;
    }
    
    #endregion
}