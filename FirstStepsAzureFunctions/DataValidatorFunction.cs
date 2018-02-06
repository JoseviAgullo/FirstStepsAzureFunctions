using FirstStepsAzureFunctions.Models;
using FirstStepsAzureFunctions.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace FirstStepsAzureFunctions
{
    public static class DataValidatorFunction
    {
        [FunctionName("DataValidatorFunction")]
		public static void Run([QueueTrigger("pokemonValidatorQueue")]Pokemon pokemon, TraceWriter log)
        {
	        log.Info($"Validating Pokemon data");

	        var validatorService = new ValidatorService();

	        var isValidPokemon = validatorService.ValidatePokemon(pokemon);

	        if (isValidPokemon)
	        {
		        log.Info("Valid Pokemon");
	        }
	        else
	        {
		        log.Warning("Invalid Pokemon");
	        }

			log.Info($"Data validator function processed");
        }
	}
}
