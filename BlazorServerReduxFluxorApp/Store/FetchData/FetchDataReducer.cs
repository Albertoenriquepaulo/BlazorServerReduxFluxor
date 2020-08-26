using BlazorServerReduxFluxorApp.Data;
using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerReduxFluxorApp.Store.FetchData
{
    public class FetchDataReducer : Reducer<FetchDataState, FetchDataAction>
    {
        private readonly WeatherForecastService _forecastService;

        public FetchDataReducer(WeatherForecastService forecastService)
        {
            _forecastService = forecastService;
            //OnInitializedAsync().Wait();
        }

        public override FetchDataState Reduce(FetchDataState state, FetchDataAction action)
        {
            return new FetchDataState(OnInitializedAsync().Result);
        }

        private async Task<WeatherForecast[]> OnInitializedAsync()
        {
            return await _forecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
