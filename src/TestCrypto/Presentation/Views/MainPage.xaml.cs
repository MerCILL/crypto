namespace TestCrypto.Presentation.Views;

public partial class MainPage : Page
{
    private readonly MainViewModel _mainViewModel;
    public MainPage(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;

        InitializeComponent();

        DataContext = mainViewModel;
    }

    private void OnDataGridDoubleClick(object sender, MouseButtonEventArgs e)
    {
        var currency = (Currency)((DataGrid)sender).SelectedItem;
        if (currency != null && _mainViewModel.NavigateToCurrencyDetailsCommand.CanExecute(currency))
            _mainViewModel.NavigateToCurrencyDetailsCommand.Execute(currency);
    }
}