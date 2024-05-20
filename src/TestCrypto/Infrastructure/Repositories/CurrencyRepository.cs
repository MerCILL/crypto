namespace TestCrypto.Infrastructure.Repositories;

public class CurrencyRepository(IHttpClientWrapper httpClient) : ICurrencyRepository
{
    private readonly IHttpClientWrapper _httpClient = httpClient;


    // https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false&x_cg_demo_api_key=CG-qR4sq8DRRzcaYnoEnaPGzQA6
    public async Task<ObservableCollection<CurrencyResponse>> GetTopNCurrencies(int n)
    {
        var url = CoinGeckoApiUrlBuilder.GetTopNCurrenciesUrl(n);
        return await CoinGeckoApiClientHelper.GetApiResponse<ObservableCollection<CurrencyResponse>>(_httpClient, url);
    }
}
