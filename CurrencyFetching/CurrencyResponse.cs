using Newtonsoft.Json;

namespace CurrencyFetching
{
    internal class CurrencyResponse
    {
        [JsonProperty("response")]
        internal CurrencyInnerResponse InnerResponse { get; set; }

        internal class CurrencyInnerResponse
        {
            [JsonProperty("rates")]
            internal Dictionary<string, string> Rates { get; set; }
        }
    }
}
