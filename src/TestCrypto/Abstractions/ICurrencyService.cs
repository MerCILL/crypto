namespace TestCrypto.Abstractions;

public interface ICurrencyService
{
    Task<ObservableCollection<Currency>> GetTopNCurrencies(int n, int page);
}