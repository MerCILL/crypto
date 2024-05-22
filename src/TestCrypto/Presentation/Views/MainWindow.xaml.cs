namespace TestCrypto;

public partial class MainWindow : Window
{
    private readonly ICurrencyService _currencyService;
    private readonly MainViewModel _mainViewModel;
    public MainWindow(ICurrencyService currencyService, MainViewModel mainViewModel)
    {
        InitializeComponent();

        WindowState = WindowState.Maximized;

        _currencyService = currencyService;
        _mainViewModel = mainViewModel;

        DataContext = mainViewModel;
    }

}