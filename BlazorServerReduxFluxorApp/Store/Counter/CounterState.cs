using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerReduxFluxorApp.Store.Counter
{
    public class CounterState
    {
        public int CurrentCount { get; }
        public CounterState(int currentCount)
        {
            CurrentCount = currentCount;
        }
    }
}
