using BlazorServerReduxFluxorApp.Data;
using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerReduxFluxorApp.Store.FetchData
{
    public class FetchDataFeature : Feature<FetchDataState>
    {

        public override string GetName() => "FetchData";

        protected override FetchDataState GetInitialState() => new FetchDataState(null);
    }
}
