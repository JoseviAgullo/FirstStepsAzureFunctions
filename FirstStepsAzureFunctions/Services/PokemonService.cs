using System.Threading.Tasks;
using FirstStepsAzureFunctions.Models;
using Newtonsoft.Json;

namespace FirstStepsAzureFunctions.Services
{
    public class PokemonService
    {
	    private const string ApiBaseUrl = "http://pokeapiservice.azurewebsites.net/pokemons";

	    public async Task<Pokemon> GetPokemon(string pokemonName)
	    {
			var httpService = new HttpService();
		    return JsonConvert.DeserializeObject<Pokemon>(await httpService.HttpGetAsync($"{ApiBaseUrl}/{pokemonName}"));
	    }
    }
}
