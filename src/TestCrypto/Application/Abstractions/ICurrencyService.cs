namespace TestCrypto.Application.Abstractions;

public interface ICurrencyService
{
    Task<ObservableCollection<Currency>> GetTopNCurrencies(int n, int page);
    Task<CurrencyDetails> GetCurrencyDetails(string id);
}