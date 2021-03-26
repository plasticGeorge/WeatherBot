using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MttfBot.Bots;
using MttfBot.HelperClasses;
using MttfBot.Interfaces;
using MttfBot.WeatherForecasters;
using VkNet;
using VkNet.Abstractions;
using VkNet.Model;

namespace MttfBot
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                    .AddNewtonsoftJson(jsonOptions =>
                    {
                        jsonOptions.SerializerSettings.ContractResolver = new CustomContractResolver();
                    });
            services.AddSingleton<IVkApi>(sp =>
            {
                var api = new VkApi();
                api.Authorize(new ApiAuthParams
                {
                    AccessToken = Configuration["Authorize:AccessToken"]
                });
                return api;
            })
                    .AddSingleton<IBot, WeatherBot>()
                    .AddSingleton<IWeatherForecaster>(sp =>
                    {
                        return new WindyPointForecaster
                        {
                            ApiToken = Configuration["WindyApi:PointForecast"]
                        };
                    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
