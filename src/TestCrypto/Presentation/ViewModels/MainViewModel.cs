namespace TestCrypto.Presentation.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private readonly ICurrencyService _currencyService;
    private ObservableCollection<Currency>? _currencies;
    private int _topN = 10;
    private int _currentPage = 1;

    public MainViewModel(ICurrencyService currencyService)
    {
        _currencyService = currencyService;
        var _ = LoadTopCurrencies();
    }

    public ObservableCollection<Currency>? Currencies
    {
        get => _currencies;
        set
        {
            _currencies = value;
            OnPropertyChanged(nameof(Currencies));
        }
    }

    public int TopN
    {
        get => _topN;
        set
        {
            _topN = value;
            OnPropertyChanged(nameof(TopN));
        }
    }

    public ICommand UpdateCurrenciesCommand => new RelayCommand(async () => await LoadTopCurrencies());

    public ICommand NextPageCommand => new RelayCommand(async () =>
    {
        _currentPage++;
        await LoadTopCurrencies();
    });

    public ICommand PreviousPageCommand => new RelayCommand(async () =>
    {
        if (_currentPage > 1)
        {
            _currentPage--;
            await LoadTopCurrencies();
        }
    });

    private async Task LoadTopCurrencies()
    {
        Currencies = await _currencyService.GetTopNCurrencies(TopN, _currentPage);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
