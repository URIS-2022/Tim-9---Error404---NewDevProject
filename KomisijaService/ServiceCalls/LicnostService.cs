using KomisijaService.DtoModels;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace KomisijaService.ServiceCalls
{
    public class LicnostService : ILicnostService
    {
        private readonly IConfiguration configuration;

        public LicnostService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Task<LicnostDto> LicnostKomisije(Guid licnostId) //async
        {
            LicnostDto licnost = new LicnostDto();
            licnost.licnostID = Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939");

            return Task.FromResult<LicnostDto>(licnost);
            //using (HttpClient client = new HttpClient())
            //{ 

            //    //Uri url = new Uri($"{ configuration["Services:LicnostService"] }api/licnost/{licnostId}");

            //    //HttpContent content = new StringContent(JsonConvert.SerializeObject(licnostId));
            //    //content.Headers.ContentType.MediaType = "application/json";

            //    //HttpResponseMessage response = client.GetAsync(url).Result;
            //    //var responseContent = await response.Content.ReadAsStringAsync();
            //    //var l = JsonConvert.DeserializeObject<LicnostDto>(responseContent);

            //    //return l;
            //}
        }
    }
}
