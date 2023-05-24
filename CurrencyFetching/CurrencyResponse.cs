using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CurrencyFetching
{
    internal class CurrencyResponse
    {
        [JsonProperty("to")]
        internal IList<Dictionary<string, string>> CurrenciesList { get; set; }
    }
}
