namespace TestCrypto.Infrastructure.Helpers.CoinGecko;

public static class CoinGeckoApiUrlBuilder
{
    public static string GetTopNCurrenciesUrl(int n, int page)
    {
        return CoinGeckoApiConstants.BaseUrl + "/coins/markets"
            + "?vs_currency=usd"
            + "&order=market_cap_desc"
            + $"&per_page={n}"
            + $"&page={page}"
            + "&sparkline=false"
            + $"&x_cg_demo_api_key={CoinGeckoApiConstants.ApiKey}";
    }

    public static string GetCurrencyDetailsUrl(string id)
    {
        return CoinGeckoApiConstants.BaseUrl + "/coins/" + id
            + "?localization=false"
            + "&tickers=true"
            + "&market_data=true"
            + "&community_data=false"
            + "&developer_data=false"
            + "&sparkline=false"
            + $"&x_cg_demo_api_key={CoinGeckoApiConstants.ApiKey}";
    }
}
