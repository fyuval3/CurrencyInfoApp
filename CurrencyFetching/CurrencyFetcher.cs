using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CurrencyFetching
{
    public static class CurrencyFetcher
    {
        private const string k_ApiMainUrl = "https://xecdapi.xe.com/v1"; // API provided by XE Currency
        private const string k_ApiUserId = "yuvalfrenkel362342689";
        private const string k_ApiUserKey = "tmvl8346g0p6o7lri14i4eiu47";

        public static string GetCurrency(eCurrency i_From, eCurrency i_To)
        {
            try
            {
                string fromString = i_From.ToString(), toString = i_To.ToString();
                HttpResponseMessage response;

                using (HttpClient client = new HttpClient())
                {
                    var authenticationString = $"{k_ApiUserId}:{k_ApiUserKey}";
                    var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));

                    Uri uri = new Uri(string.Format("{0}/convert_from?from={1}&to={2}", k_ApiMainUrl, fromString, toString));

                    var requestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);

                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    client.DefaultRequestHeaders.Add(k_ApiUserId, k_ApiUserKey);

                    response = client.SendAsync(requestMessage).Result;
                }

                response.EnsureSuccessStatusCode();

                string jsonString = response.Content.ReadAsStringAsync().Result;
                CurrencyResponse currencyResponse = JsonConvert.DeserializeObject<CurrencyResponse>(jsonString);

                string currency = currencyResponse.CurrenciesList[0]["mid"];

                return currency;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}