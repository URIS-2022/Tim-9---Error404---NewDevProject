﻿using Newtonsoft.Json;
using UgovorZakupService.DtoModels;

namespace UgovorZakupService.ServiceCalls
{
    public class LoggerService : ILoggerService
    {
        private readonly IConfiguration configuration;

        public LoggerService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void CreateMessage(Message message)
        {
            using (HttpClient client = new HttpClient())
            {

                Uri url = new Uri($"{configuration["Services:LoggerService"]}api/logger");

                HttpContent content = new StringContent(JsonConvert.SerializeObject(message));
                content.Headers.ContentType.MediaType = "application/json";

            }
        }
    }
}
