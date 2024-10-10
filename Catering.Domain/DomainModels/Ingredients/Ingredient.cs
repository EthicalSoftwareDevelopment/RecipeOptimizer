namespace Catering.Domain.DomainModels;

public class Ingredient
{
    #region Properties
    
    public string Name { get; set; }
    public FoodType FoodType { get; set; }
    
    #endregion
    
    #region Constructors

    public Ingredient()
    {
        FoodType = FoodType.Unknown;
    }
    
    public Ingredient(FoodType foodType)
    {
        FoodType = FoodType.Unknown;
    }
    
    #endregion
}