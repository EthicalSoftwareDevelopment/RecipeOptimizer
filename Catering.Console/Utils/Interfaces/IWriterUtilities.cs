using Catering.Domain.DomainModels;
using Catering.Domain.DomainModels.Ingredients;

namespace Catering.Console.Utils.Interfaces
{
    public interface IWriterUtilities
    {
        public void WriteIngredients(List<KeyValuePair<Ingredient, int>> ingredients);

        public void WriteSetMenu(SetMenu bestCookingOption);
    }
}