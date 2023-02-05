using System;
using AuctionService.Entities;
using AuctionService.Repository;
using AuctionService.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AuctionService.ServiceCalls;

namespace AuctionService
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers(setup =>
            {
                setup.ReturnHttpNotAcceptable = true; //svaki put kad stigne nesto sto nije eksplicitno podrzano vrati odgovarajuci status i stavi do ynanja klijentu da to nije podrzano 
            }).AddXmlDataContractSerializerFormatters()//ovim je podrzan i xml
                                                       //svaki put kad vidis interfejs da se trazi prosledi konkretnu implementaciju tog interfejsa koja je proslednjena
                                                       //napravi mi instancu toga sto zelis svaki put kada dodje novi request. svaki put kad stigne novi request od kljenta napravice se nova instanca toga necega
                .ConfigureApiBehaviorOptions(setupAction => //Deo koji se odnosi na podrzavanje Problem Details for HTTP APIs
                {
                    setupAction.InvalidModelStateResponseFactory = context =>
                    {
                        //Kreiramo problem details objekat
                        ProblemDetailsFactory problemDetailsFactory = context.HttpContext.RequestServices
                            .GetRequiredService<ProblemDetailsFactory>();

                        //Prosledjujemo trenutni kontekst i ModelState, ovo prevodi validacione greske iz ModelState-a u RFC format
                        ValidationProblemDetails problemDetails = problemDetailsFactory.CreateValidationProblemDetails(
                            context.HttpContext,
                            context.ModelState);

                        //Ubacujemo dodatne podatke
                        problemDetails.Detail = "Pogledajte polje errors za detalje.";
                        problemDetails.Instance = context.HttpContext.Request.Path;

                        //po defaultu se sve vraca kao status 400 BadRequest, to je ok kada nisu u pitanju validacione greske,
                        //ako jesu hocemo da koristimo status 422 UnprocessibleEntity
                        //trazimo info koji status kod da koristimo
                        var actionExecutiongContext = context as ActionExecutingContext;

                        //proveravamo da li postoji neka greska u ModelState-u, a takodje proveravamo da li su svi prosledjeni parametri dobro parsirani
                        //ako je sve ok parsirano ali postoje greske u validaciji hocemo da vratimo status 422
                        if ((context.ModelState.ErrorCount > 0) &&
                            (actionExecutiongContext?.ActionArguments.Count == context.ActionDescriptor.Parameters.Count))
                        {
                            problemDetails.Type = "https://google.com"; //inace treba da stoji link ka stranici sa detaljima greske
                            problemDetails.Status = StatusCodes.Status422UnprocessableEntity;
                            problemDetails.Title = "Doslo je do greske prilikom validacije.";

                            //sve vracamo kao UnprocessibleEntity objekat
                            return new UnprocessableEntityObjectResult(problemDetails)
                            {
                                ContentTypes = { "application/problem+json" }
                            };
                        };

                        //ukoliko postoji nesto što nije moglo da se parsira hocemo da vracamo status 400 kao i do sada
                        problemDetails.Status = StatusCodes.Status400BadRequest;
                        problemDetails.Title = "Doslo je do greske prilikom parsiranja poslatog sadrzaja.";
                        return new BadRequestObjectResult(problemDetails)
                        {
                            ContentTypes = { "application/problem+json" }
                        };
                    };
                });
            //services.AddSingleton<ITipJavnogNadmetanjaRepository, TipJavnogNadmetanjaRepository>();
            services.AddScoped<ITipNadmetanjaRepository, TipNadmetanjaService>();
            services.AddScoped<IStatusNadmetanjaRepository, StatusNadmetanjaService>();
            services.AddScoped<IJavnoNadmetanjeRepository, JavnoNadmetanjeService>();
            services.AddScoped<ILicitacijaRepository, LicitacijaService>();
            services.AddScoped<IAdresaService, AdresaService>();
            services.AddScoped<IOvlascenoLiceService, OvlascenoLiceService>();
            services.AddScoped<IKupacService, KupacService>();
            services.AddScoped<IParcelaService, ParcelaService>();
            //services.AddScoped<IUserRepository, UserMockRepository>();
            //services.AddScoped<IAuthenticationHelper, AuthenticationHelper>();
            //services.AddScoped<ILoggerService, LoggerService>();
            //services.AddScoped<IKupacService, KupacService>();

            //konfiguracije za automaper - pogledaj ceo domen gde se izvrsava servis i trazi konfiguracije za automapper.
            //te konfiguracije su profili, za svako mapiranje ce se definisati jedan profil i reci iz tog objekta mapitaj u taj objekat na takav nacin
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                else
                {
                    app.UseExceptionHandler(appBuilder => //u slucaju da se vrati statusni kod 500 da klijentu ispise ovakvu gresku jer je to nas problem, a ne korisnikov
                    {
                        appBuilder.Run(async context =>
                        {
                            context.Response.StatusCode = 500;
                            await context.Response.WriteAsync("Doslo je do neocekivane greske. Molimo pokusajte kasnije.");
                        });
                    });
                }

                app.UseHttpsRedirection();

                app.UseRouting();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }


        
    }

}

