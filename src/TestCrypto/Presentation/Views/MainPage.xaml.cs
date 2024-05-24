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

    private void OnListBoxDoubleClick(object sender, MouseButtonEventArgs e)
    {
        if (sender is ListBox listBox && listBox.SelectedItem is Currency currency)
        {
            if (_mainViewModel.NavigateToCurrencyDetailsCommand.CanExecute(currency))
                _mainViewModel.NavigateToCurrencyDetailsCommand.Execute(currency);
        }
    }

    private void ToggleButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is ToggleButton toggleButton && toggleButton.IsChecked.HasValue)
        {
            string darkThemePath = "pack://application:,,,/TestCrypto;component/Presentation/MainPageDarkThemeStylesDictionary.xaml";
            string lightThemePath = "pack://application:,,,/TestCrypto;component/Presentation/MainPageLightThemeStylesDictionary.xaml";

            var newTheme = new ResourceDictionary { Source = toggleButton.IsChecked.Value ? new Uri(darkThemePath, UriKind.Absolute) : new Uri(lightThemePath, UriKind.Absolute) };

            this.Resources.MergedDictionaries.Clear();
            this.Resources.MergedDictionaries.Add(newTheme);
        }
    }
}