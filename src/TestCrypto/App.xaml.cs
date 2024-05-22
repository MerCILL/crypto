namespace TestCrypto;

public partial class App : System.Windows.Application
{
    public static IHost? AppHost { get; private set; }

    public App()
    {
        AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<MainWindow>();

                services.AddTransient<ICurrencyRepository, CurrencyRepository>();
                services.AddTransient<ICurrencyService, CurrencyService>();
                services.AddAutoMapper(typeof(CurrencyMappingProfile));
                services.AddSingleton<IHttpClientWrapper, HttpClientWrapper>();
                services.AddTransient<MainViewModel>();

                services.AddSingleton<HttpClient>();
            })
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await AppHost!.StartAsync();

        var startupFrom = AppHost.Services.GetRequiredService<MainWindow>();
        startupFrom.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost!.StopAsync();
        base.OnExit(e);
    }
}
