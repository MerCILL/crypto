namespace TestCrypto.Infrastructure.Abstractions;

public interface ICurrencyRepository
{
    Task<ObservableCollection<CurrencyResponse>> GetTopNCurrencies(int n);
}