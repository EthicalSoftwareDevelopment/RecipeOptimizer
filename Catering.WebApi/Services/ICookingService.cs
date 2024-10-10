using Catering.Domain.DomainModels;

namespace Catering.WebApi.Services;

public interface ICookingService
{
    public SetMenu CalculateBestOption();
}