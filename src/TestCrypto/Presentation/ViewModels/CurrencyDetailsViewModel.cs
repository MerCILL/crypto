namespace TestCrypto.Presentation.ViewModels;

public class CurrencyDetailsViewModel : INotifyPropertyChanged
{
    private readonly ICurrencyService _currencyService;
    private readonly string _currencyId;
    private CurrencyDetails? _currencyDetails;

    public CurrencyDetailsViewModel(ICurrencyService currencyService, string currencyId)
    {
        _currencyService = currencyService;
        _currencyId = currencyId;
        var _ = LoadCurrencyDetails();
    }

    public CurrencyDetails? CurrencyDetails
    {
        get => _currencyDetails;
        set
        {
            _currencyDetails = value;
            OnPropertyChanged(nameof(CurrencyDetails));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private async Task LoadCurrencyDetails()
    {
        CurrencyDetails = await _currencyService.GetCurrencyDetails(_currencyId);
    }

    public ICommand NavigateBackCommand => new RelayCommand(NavigateBack);

    private void NavigateBack()
    {
        var mainWindow = (MainWindow)System.Windows.Application.Current.MainWindow;

        var mainViewModel = new MainViewModel(_currencyService);

        var mainPage = new MainPage(mainViewModel);

        mainWindow.MainFrame.Navigate(mainPage);
    }
}