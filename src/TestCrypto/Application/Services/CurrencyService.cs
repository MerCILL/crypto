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
}

