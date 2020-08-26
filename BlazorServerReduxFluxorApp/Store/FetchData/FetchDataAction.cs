using BlazorServerReduxFluxorApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerReduxFluxorApp.Store.FetchData
{
    public class FetchDataAction
    {
        private readonly WeatherForecastService _forecastService;

        public FetchDataAction(WeatherForecastService forecastService)
        {
            _forecastService = forecastService;
        }

        public async Task<WeatherForecast[]> GetWeatherForecastDataAsync()
        {
            return await _forecastService.GetForecastAsync(DateTime.Now);
        }

    }
}
