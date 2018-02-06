using FirstStepsAzureFunctions.Models;

namespace FirstStepsAzureFunctions.Services
{
    public class ValidatorService
    {
	    public bool ValidatePokemon(Pokemon pokemon)
	    {
		    return pokemon.Id != null && !string.IsNullOrEmpty(pokemon.Name);
	    }
	}
}
