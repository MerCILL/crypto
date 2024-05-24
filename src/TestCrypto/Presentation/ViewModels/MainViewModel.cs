namespace TestCrypto.Presentation.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private readonly ICurrencyService _currencyService;
    private ObservableCollection<Currency>? _currencies;
    private ObservableCollection<Currency>? _searchResults;
    private int _topN = 100;
    private int _currentPage = 1;
    private string _searchText = string.Empty;

    public MainViewModel(ICurrencyService currencyService)
    {
        _currencyService = currencyService;
        _ = LoadTopCurrencies();
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

    public ObservableCollection<Currency>? SearchResults
    {
        get => _searchResults;
        set
        {
            _searchResults = value;
            OnPropertyChanged(nameof(SearchResults));
        }
    }

    public string SearchText
    {
        get => _searchText;
        set
        {
            if (_searchText != value)
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
                SearchCommand.Execute(_searchText);
            }
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

    public ICommand NavigateToCurrencyDetailsCommand => new RelayCommand<Currency?>(NavigateToCurrencyDetailsPage);

    public ICommand SearchCommand => new RelayCommand<string>(async (searchText) =>
    {
        searchText ??= string.Empty;
        await SearchCurrencies(searchText);
    });

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private async Task LoadTopCurrencies()
    {
        Currencies = await _currencyService.GetTopNCurrencies(TopN, _currentPage);
    }

    private void NavigateToCurrencyDetailsPage(Currency? currency)
    {
        if (currency != null)
        {
            var viewModel = new CurrencyDetailsViewModel(_currencyService, currency.Id);
            var detailsPage = new CurrencyDetailsPage(viewModel);
            var mainWindow = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainWindow.MainFrame.Navigate(detailsPage);
        }
    }

    private async Task SearchCurrencies(string searchText)
    {
        if (string.IsNullOrEmpty(searchText))
        {
            SearchResults = null;
        }
        else
        {
            SearchResults = searchText.Length == 3
                ? await _currencyService.SearchCurrenciesByCode(searchText)
                : await _currencyService.SearchCurrenciesByName(searchText);
        }
    }
}


