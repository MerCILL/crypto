namespace TestCrypto.Infrastructure.Helpers;

public static class CoinGeckoApiClientHelper
{
    public const string BaseUrl = "https://api.coingecko.com/api/v3";
    public const string ApiKey = "CG-qR4sq8DRRzcaYnoEnaPGzQA6";

    public static async Task<T> GetApiResponse<T>(HttpClient httpClient, string url)
    {
        var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<T>(content)!;
    }
}
