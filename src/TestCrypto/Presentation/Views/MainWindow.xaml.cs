namespace TestCrypto;

public partial class MainWindow : Window
{
    public MainWindow(MainViewModel mainViewModel)
    {
        InitializeComponent();
        WindowState = WindowState.Maximized;

        MainFrame.Content = new MainPage(mainViewModel);
    }
}