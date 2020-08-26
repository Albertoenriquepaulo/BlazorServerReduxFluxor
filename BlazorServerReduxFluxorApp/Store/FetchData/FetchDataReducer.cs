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
            //return new FetchDataState(GetWeatherForecastDataAsync().Result);
            return new FetchDataState(action.GetWeatherForecastDataAsync().Result);

            //No estoy seguro cual de estas dos formas es correcta, 
            //si usamos la 1era, debemos modificar en FetchData.razor la llamada al 
            //Dispatcher.Dispatch(new FetchDataAction());
            //Es decir sin eviarle el servicio dentro de FetchDataAction
        }

        private async Task<WeatherForecast[]> GetWeatherForecastDataAsync()
        {
            return await _forecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
