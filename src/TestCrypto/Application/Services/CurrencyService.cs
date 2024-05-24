namespace TestCrypto.Application.Services;

public class CurrencyService(ICurrencyRepository currencyRepository, IMapper mapper) : ICurrencyService
{
    private readonly ICurrencyRepository _currencyRepository = currencyRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<ObservableCollection<Currency>> GetTopNCurrencies(int n, int page)
    {
        var response = await _currencyRepository.GetTopNCurrencies(n, page);
        var currencies = _mapper.Map<ObservableCollection<Currency>>(response);
        return currencies;
    }

    public async Task<CurrencyDetails> GetCurrencyDetails(string id)
    {
        var response = await _currencyRepository.GetCurrencyDetails(id);
        return _mapper.Map<CurrencyDetails>(response);
    }

    public async Task<ObservableCollection<Currency>> SearchCurrenciesByName(string name)
    {
        var currencies = new ObservableCollection<Currency>();
        for (int page = 1; page <= 4; page++)
        {
            var response = await _currencyRepository.GetTopNCurrencies(250, page);
            var pageCurrencies = _mapper.Map<ObservableCollection<Currency>>(response);
            var filteredCurrencies = new ObservableCollection<Currency>(pageCurrencies.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase)));
            foreach (var currency in filteredCurrencies)
            {
                currencies.Add(currency);
            }
        }
        return currencies;
    }

    public async Task<ObservableCollection<Currency>> SearchCurrenciesByCode(string code)
    {
        var currencies = new ObservableCollection<Currency>();
        for (int page = 1; page <= 4; page++)
        {
            var response = await _currencyRepository.GetTopNCurrencies(250, page);
            var pageCurrencies = _mapper.Map<ObservableCollection<Currency>>(response);
            var filteredCurrencies = new ObservableCollection<Currency>(pageCurrencies.Where(c => c.Symbol.Contains(code, StringComparison.OrdinalIgnoreCase)));
            foreach (var currency in filteredCurrencies)
            {
                currencies.Add(currency);
            }
        }
        return currencies;
    }
}

