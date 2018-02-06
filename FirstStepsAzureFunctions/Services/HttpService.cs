using System.Net.Http;
using System.Threading.Tasks;

namespace FirstStepsAzureFunctions.Services
{
	public class HttpService
	{
		public async Task<string> HttpGetAsync(string url)
		{
			using (var client = new HttpClient())
			{
				var website = await client.GetAsync(url);
				return await website.Content.ReadAsStringAsync();
			}
		}
	}
}
