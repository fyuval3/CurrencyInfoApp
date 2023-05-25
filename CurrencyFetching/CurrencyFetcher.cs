using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CurrencyFetching
{
    public static class CurrencyFetcher
    {
        private const string k_ApiMainUrl = "https://api.currencybeacon.com/v1"; // API provided by CurrencyBeacon
        private const string k_ApiKey = "9ffec33ed333e09e548678769aa14179";

        public static string GetCurrency(eCurrency i_From, eCurrency i_To)
        {
            try
            {
                string fromString = i_From.ToString(), toString = i_To.ToString();
                HttpResponseMessage response;

                using (HttpClient client = new HttpClient())
                {
                    Uri uri = new Uri($"{k_ApiMainUrl}/latest?base={fromString}&symbols={toString}&api_key={k_ApiKey}");
                    response = client.GetAsync(uri).Result;
                }

                response.EnsureSuccessStatusCode();

                string jsonString = response.Content.ReadAsStringAsync().Result;
                CurrencyResponse currencyResponse = JsonConvert.DeserializeObject<CurrencyResponse>(jsonString);

                string currency = currencyResponse.InnerResponse.Rates[toString];

                return currency;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}