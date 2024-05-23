namespace TestCrypto;

public partial class MainWindow : Window
{
    private readonly ICurrencyService _currencyService;
    private readonly MainViewModel _mainViewModel;

    public MainWindow(ICurrencyService currencyService, MainViewModel mainViewModel)
    {
        _currencyService = currencyService;
        _mainViewModel = mainViewModel;
        InitializeComponent();
        WindowState = WindowState.Maximized;

        MainFrame.Content = new MainPage(currencyService, mainViewModel);
    }

}