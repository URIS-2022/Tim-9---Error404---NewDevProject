using System;
using AuctionService.DtoModels;
using Newtonsoft.Json;

namespace AuctionService.ServiceCalls
{
	public class OvlascenoLiceService : IOvlascenoLiceService
	{
        private readonly IConfiguration Configuration;
		public OvlascenoLiceService(IConfiguration Configuration)
		{
            this.Configuration = Configuration;
		}

        public async Task<OvlascenoLiceDto> getOvlascenoLice(Guid ovlascenoLiceId)
        {
            using (HttpClient client = new HttpClient())
            {

                Uri url = new Uri($"{Configuration["Services:Ovlasceno_lice"]}api/ovlascenaLica/{ovlascenoLiceId}");

                HttpContent content = new StringContent(JsonConvert.SerializeObject(ovlascenoLiceId));
                content.Headers.ContentType.MediaType = "application/json";

                HttpResponseMessage response = client.GetAsync(url).Result;
                var responseContent = await response.Content.ReadAsStringAsync();
                var k = JsonConvert.DeserializeObject<OvlascenoLiceDto>(responseContent);

                return k;
            }
        }
    }
}

