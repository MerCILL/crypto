namespace TestCrypto.Infrastructure.Repositories;

public class CurrencyRepository(IHttpClientWrapper httpClient) : ICurrencyRepository
{
    private readonly IHttpClientWrapper _httpClient = httpClient;


    // https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false&x_cg_demo_api_key=CG-qR4sq8DRRzcaYnoEnaPGzQA6
    public async Task<ObservableCollection<CurrencyResponse>> GetTopNCurrencies(int n, int page)
    {
        var url = CoinGeckoApiUrlBuilder.GetTopNCurrenciesUrl(n, page);
        return await CoinGeckoApiClientHelper.GetApiResponse<ObservableCollection<CurrencyResponse>>(_httpClient, url);
    }

    // https://api.coingecko.com/api/v3/coins/bitcoin?localization=false&tickers=true&market_data=true&community_data=false&developer_data=false&sparkline=false&x_cg_demo_api_key=CG-qR4sq8DRRzcaYnoEnaPGzQA6
    public async Task<CurrencyDetailsResponse> GetCurrencyDetails(string id)
    {
        var url = CoinGeckoApiUrlBuilder.GetCurrencyDetailsUrl(id);
        return await CoinGeckoApiClientHelper.GetApiResponse<CurrencyDetailsResponse>(_httpClient, url);
    }
}

