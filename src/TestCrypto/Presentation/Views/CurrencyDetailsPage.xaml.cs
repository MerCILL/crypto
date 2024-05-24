namespace TestCrypto.Presentation.Views;

public partial class CurrencyDetailsPage : Page
{
    public CurrencyDetailsPage(CurrencyDetailsViewModel currencyDetailsViewModel)
    {
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

