namespace TestCrypto.Presentation.Views;

public partial class CurrencyDetailsPage : Page
{
    private readonly CurrencyDetailsViewModel _currencyDetailsViewModel;
    public CurrencyDetailsPage(CurrencyDetailsViewModel currencyDetailsViewModel)
    {
        _currencyDetailsViewModel = currencyDetailsViewModel;

        InitializeComponent();
        DataContext = currencyDetailsViewModel;
    }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        var psi = new ProcessStartInfo
        {
            FileName = e.Uri.AbsoluteUri,
            UseShellExecute = true
        };
        Process.Start(psi);
        e.Handled = true;
    }
}

