namespace TestCrypto.Models;

public class CurrencyDetails : INotifyPropertyChanged
{
    private string _id = null!;
    private string _symbol = null!;
    private string _name = null!;
    private int _marketCapRank;
    private MarketData _marketData = null!;
    private List<Ticker> _tickers = null!;

    public string Id
    {
        get { return _id; }
        set
        {
            if (_id != value)
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
    }

    public string Symbol
    {
        get { return _symbol; }
        set
        {
            if (_symbol != value)
            {
                _symbol = value;
                OnPropertyChanged(nameof(Symbol));
            }
        }
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (_name != value)
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    public int MarketCapRank
    {
        get { return _marketCapRank; }
        set
        {
            if (_marketCapRank != value)
            {
                _marketCapRank = value;
                OnPropertyChanged(nameof(MarketCapRank));
            }
        }
    }

    public MarketData MarketData
    {
        get { return _marketData; }
        set
        {
            if (_marketData != value)
            {
                _marketData = value;
                OnPropertyChanged(nameof(MarketData));
            }
        }
    }

    public List<Ticker> Tickers
    {
        get { return _tickers; }
        set
        {
            if (_tickers != value)
            {
                _tickers = value;
                OnPropertyChanged(nameof(Tickers));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}


public class MarketData : INotifyPropertyChanged
{
    private Dictionary<string, decimal> _marketCap = null!;
    private Dictionary<string, decimal> _totalVolume = null!;
    private decimal? _circulatingSupply;
    private decimal? _priceChange24h;
    private decimal? _priceChangePercentage24h;

    public Dictionary<string, decimal> MarketCap
    {
        get { return _marketCap; }
        set
        {
            if (_marketCap != value)
            {
                _marketCap = value;
                OnPropertyChanged(nameof(MarketCap));
            }
        }
    }

    public Dictionary<string, decimal> TotalVolume
    {
        get { return _totalVolume; }
        set
        {
            if (_totalVolume != value)
            {
                _totalVolume = value;
                OnPropertyChanged(nameof(TotalVolume));
            }
        }
    }

    public decimal? CirculatingSupply
    {
        get { return _circulatingSupply; }
        set
        {
            if (_circulatingSupply != value)
            {
                _circulatingSupply = value;
                OnPropertyChanged(nameof(CirculatingSupply));
            }
        }
    }

    public decimal? PriceChange24h
    {
        get { return _priceChange24h; }
        set
        {
            if (_priceChange24h != value)
            {
                _priceChange24h = value;
                OnPropertyChanged(nameof(PriceChange24h));
            }
        }
    }

    public decimal? PriceChangePercentage24h
    {
        get { return _priceChangePercentage24h; }
        set
        {
            if (_priceChangePercentage24h != value)
            {
                _priceChangePercentage24h = value;
                OnPropertyChanged(nameof(PriceChangePercentage24h));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class Ticker : INotifyPropertyChanged
{
    private string _base = null!;
    private string _target = null!;
    private Market _market = null!;

    public string Base
    {
        get { return _base; }
        set
        {
            if (_base != value)
            {
                _base = value;
                OnPropertyChanged(nameof(Base));
            }
        }
    }

    public string Target
    {
        get { return _target; }
        set
        {
            if (_target != value)
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }
    }

    public Market Market
    {
        get { return _market; }
        set
        {
            if (_market != value)
            {
                _market = value;
                OnPropertyChanged(nameof(Market));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class Market : INotifyPropertyChanged
{
    private string _name = null!;

    public string Name
    {
        get { return _name; }
        set
        {
            if (_name != value)
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
