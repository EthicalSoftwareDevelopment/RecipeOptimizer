namespace Catering.Domain.DomainModels;

public class Recipe
{
    
    #region Properties
    
    public List<Ingredient> Ingredients { get; set; }
    public int PeopleFed { get; set; }
    
    #endregion
    
    #region Constructors

    public Recipe()
    {
       Ingredients = new List<Ingredient>();
    }

    #endregion
    
    #region Methods
    
    
    
    #endregion
}