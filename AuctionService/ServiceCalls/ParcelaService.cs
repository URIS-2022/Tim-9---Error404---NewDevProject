using System;
using AuctionService.DtoModels;
using Newtonsoft.Json;

namespace AuctionService.ServiceCalls
{
	public class ParcelaService : IParcelaService
	{
        private readonly IConfiguration Configuration;
		public ParcelaService(IConfiguration Configuration)
		{
            this.Configuration = Configuration;
		}

        public async Task<ParcelaDto> getParcela(Guid parcelaId)
        {
            using (HttpClient client = new HttpClient())
            {

                Uri url = new Uri($"{Configuration["Services:Parcela"]}api/parcela/{parcelaId}");

                HttpContent content = new StringContent(JsonConvert.SerializeObject(parcelaId));
                content.Headers.ContentType.MediaType = "application/json";

                HttpResponseMessage response = client.GetAsync(url).Result;
                var responseContent = await response.Content.ReadAsStringAsync();
                var k = JsonConvert.DeserializeObject<ParcelaDto>(responseContent);

                return k;
            }
        }
    }
}

