using System.Threading.Tasks;
using FirstStepsAzureFunctions.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace FirstStepsAzureFunctions
{
    public static class GetDataFunction
	{
		[FunctionName("GetDataFunction")]
		public static async Task Run([TimerTrigger("* */5 * * * *")]TimerInfo myTimer, TraceWriter log)
		{
			var pokemonService = new PokemonService();
			log.Info("Getting data from API");
			var pokemon = await pokemonService.GetPokemon("charizard");
		}
	}
}
