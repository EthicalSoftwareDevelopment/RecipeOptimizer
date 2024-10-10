using Catering.Domain.DomainModels.Recipes;

namespace Catering.Domain.DomainModels;

public class SetMenu
{
    #region Properties
    public List<Recipe> Recipes { get; set; } 
    
    #endregion
    
    #region Constructors
    
    public SetMenu()
    {
        Recipes = new List<Recipe>();
    }
    
    #endregion
    
    #region Methods
    
    
    
    #endregion
}