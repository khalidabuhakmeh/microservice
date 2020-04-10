using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        public WeatherForecast[] Forecasts { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            this.logger = logger;
        }

        public async Task OnGet([FromServices]WeatherClient client)
        {
            Forecasts = await client.GetWeatherAsync();
        }
    }
}
