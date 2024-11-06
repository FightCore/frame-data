using RestSharp;

namespace FightCore.Enricher
{
	public class ImageUrlValidator
	{
		private readonly RestClient _restClient;

        public ImageUrlValidator(string baseUrl = "https://i.fightcore.gg")
        {
            _restClient = new RestClient(baseUrl);
        }

        public async Task<bool> Validate(string image)
        {
			try
			{
				var request = new RestRequest(image);
				var response = await _restClient.GetAsync(request);
				if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
				{
					return false;
				}

				return true;
			}
			catch
			{
				return false;
			}
		}
    }
}
