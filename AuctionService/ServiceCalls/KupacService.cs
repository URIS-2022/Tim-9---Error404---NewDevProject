using System;
using AuctionService.DtoModels;
using Newtonsoft.Json;

namespace AuctionService.ServiceCalls
{
	public class KupacService : IKupacService
	{
        private readonly IConfiguration Configuration;
		public KupacService(IConfiguration configuration)
		{
            this.Configuration = configuration;
		}

        public async Task<KupacDto> getKupci(Guid kupacId)
        {
            using (HttpClient client = new HttpClient())
            {

                Uri url = new Uri($"{Configuration["Services:Kupac"]}api/kupac/{kupacId}");

                HttpContent content = new StringContent(JsonConvert.SerializeObject(kupacId));
                content.Headers.ContentType.MediaType = "application/json";

                HttpResponseMessage response = client.GetAsync(url).Result;
                var responseContent = await response.Content.ReadAsStringAsync();
                var k = JsonConvert.DeserializeObject<KupacDto>(responseContent);

                return k;
            }
    }
}

