using Newtonsoft.Json;

namespace FirstStepsAzureFunctions.Models
{
    public class Pokemon
    {
		[JsonProperty("Id")]
		public string Id { get; set; }

		[JsonProperty("Name")]
		public string Name { get; set; }

		[JsonProperty("Types")]
		public string[] Types { get; set; }

		[JsonProperty("Avatar")]
		public string Avatar { get; set; }

		[JsonProperty("Url")]
		public string Url { get; set; }
	}
}
