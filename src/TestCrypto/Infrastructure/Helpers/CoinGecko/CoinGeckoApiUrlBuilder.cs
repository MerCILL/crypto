namespace TestCrypto.Infrastructure.Helpers;

public static class CoinGeckoApiUrlBuilder
{
    public static string GetTopNCurrenciesUrl(int n)
    {
        return CoinGeckoApiConstants.BaseUrl + "/coins/markets"
            + "?vs_currency=usd"
            + "&order=market_cap_desc"
            + $"&per_page={n}"
            + $"&page={1}"
            + "&sparkline=false"
            + $"&x_cg_demo_api_key={CoinGeckoApiConstants.ApiKey}";
    }
}
