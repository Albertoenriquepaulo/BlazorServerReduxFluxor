using BlazorServerReduxFluxorApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerReduxFluxorApp.Store.FetchData
{
    public class FetchDataState
    {
        public WeatherForecast[] Forecasts;

        public FetchDataState(WeatherForecast[] forecasts)
        {
            Forecasts = forecasts;
        }
    }
}
