namespace TestCrypto.Presentation.Views;

public partial class MainPage : Page
{
    private readonly ICurrencyService _currencyService;
    private readonly MainViewModel _mainViewModel;
    public MainPage(ICurrencyService currencyService, MainViewModel mainViewModel)
    {
        InitializeComponent();

        _currencyService = currencyService;
        _mainViewModel = mainViewModel;

        DataContext = mainViewModel;
    }
}
