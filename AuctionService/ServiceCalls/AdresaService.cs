using System;
using AuctionService.DtoModels;
using Newtonsoft.Json;

namespace AuctionService.ServiceCalls
{
	public class AdresaService : IAdresaService
	{
        private readonly IConfiguration Configuration;

        public AdresaService(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public async Task<AdresaDto> getAdresa(Guid adresaId)
        {
            using (HttpClient client = new HttpClient())
            {

                Uri url = new Uri($"{Configuration["Services:Adresa"]}api/adresa/{adresaId}");
                Console.WriteLine(url);

                HttpContent content = new StringContent(JsonConvert.SerializeObject(adresaId));
                content.Headers.ContentType.MediaType = "application/json";

                HttpResponseMessage response = client.GetAsync(url).Result;
                var responseContent = await response.Content.ReadAsStringAsync();
                var a = JsonConvert.DeserializeObject<AdresaDto>(responseContent);

                return a;
            }
        }
    }
}

