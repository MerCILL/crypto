namespace TestCrypto.Infrastructure.Abstractions;

public interface ICurrencyRepository
{
    Task<ObservableCollection<CurrencyResponse>> GetTopNCurrencies(int n, int page);
    Task<CurrencyDetailsResponse> GetCurrencyDetails(string id);
}