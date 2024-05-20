namespace TestCrypto.Infrastructure.Helpers.CoinGecko;

public static class CoinGeckoApiClientHelper
{
    public static async Task<T> GetApiResponse<T>(IHttpClientWrapper httpClient, string url)
    {
        var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<T>(content)!;
    }
}
