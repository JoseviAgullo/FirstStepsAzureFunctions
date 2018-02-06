using System.Threading.Tasks;
using FirstStepsAzureFunctions.Models;
using FirstStepsAzureFunctions.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace FirstStepsAzureFunctions
{
    public static class GetDataFunction
	{
		[FunctionName("GetDataFunction")]
		[return: Queue("pokemonValidatorQueue")]
		public static async Task<Pokemon> Run([TimerTrigger("* */5 * * * *")]TimerInfo myTimer, TraceWriter log)
		{
			var pokemonService = new PokemonService();
			log.Info("Getting data from API");
			var pokemon = await pokemonService.GetPokemon("charizard");

			return pokemon;
		}
	}
}
