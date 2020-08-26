using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://betweentwobrackets.dev/posts/2020/06/state-management-with-blazor-using-fluxor-part-1/

namespace BlazorServerReduxFluxorApp.Store.Counter
{
    public class CounterFeature : Feature<CounterState>
    {
        public override string GetName() => "Counter";

        protected override CounterState GetInitialState() => new CounterState(0);
    }
}
